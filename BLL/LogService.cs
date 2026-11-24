using EPCMS.DAL;
using EPCMS.DAL.Interfaces;
using EPCMS.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace EPCMS.BLL
{
    /// <summary>
    /// 日志业务层：写日志（数据库 + 文件双通道）、查询、导出、清理
    /// </summary>
    public class LogService
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly LogRepository _repository;

        public LogService(IDbHelper db)
        {
            _repository = new LogRepository(db);
        }

        /// <summary>
        /// 同步写一条日志：先写 NLog 文件，再写数据库；数据库异常只记文件不抛出，
        /// 保证「日志写失败」不会把业务操作搞崩。
        /// </summary>
        public void Write(string module, string actionType, string detail, string result = "成功")
        {
            var entry = new LogEntry
            {
                LogTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                UserName = Environment.UserName,
                Module = module,
                ActionType = actionType,
                Detail = detail,
                Result = result
            };

            try
            {
                if (string.Equals(result, "失败", StringComparison.Ordinal))
                    Logger.Warn($"[{module}/{actionType}] {detail}");
                else
                    Logger.Info($"[{module}/{actionType}] {detail}");
            }
            catch
            {
                // 文件日志失败不影响主流程
            }

            try
            {
                _repository.Insert(entry);
            }
            catch (Exception ex)
            {
                try { Logger.Error(ex, "写数据库日志失败"); } catch { }
            }
        }

        /// <summary>后台线程写日志，界面操作不等待数据库</summary>
        public void WriteAsync(string module, string actionType, string detail, string result = "成功")
        {
            Task.Run(() => Write(module, actionType, detail, result));
        }

        public int Count(DateTime from, DateTime to, string actionType, string keyword)
        {
            return _repository.Count(from, to, actionType, keyword);
        }

        public List<LogEntry> QueryPage(DateTime from, DateTime to, string actionType, string keyword, int page, int pageSize)
        {
            return _repository.QueryPage(from, to, actionType, keyword, page, pageSize);
        }

        public List<LogEntry> QueryAll(DateTime from, DateTime to, string actionType, string keyword)
        {
            return _repository.QueryAll(from, to, actionType, keyword);
        }

        /// <summary>清理 N 天以前的日志</summary>
        public int CleanBefore(int days)
        {
            return _repository.DeleteBefore(DateTime.Now.AddDays(-days));
        }

        public int CleanAll()
        {
            return _repository.DeleteAll();
        }

        /// <summary>导出 CSV 文本（带表头，字段含逗号/引号/换行时自动转义）</summary>
        public static string BuildCsv(List<LogEntry> logs)
        {
            var sb = new StringBuilder();
            sb.AppendLine("时间,操作人,模块,操作类型,内容,结果");
            if (logs != null)
            {
                foreach (var log in logs)
                {
                    sb.Append(Escape(log.LogTime)).Append(',')
                      .Append(Escape(log.UserName)).Append(',')
                      .Append(Escape(log.Module)).Append(',')
                      .Append(Escape(log.ActionType)).Append(',')
                      .Append(Escape(log.Detail)).Append(',')
                      .Append(Escape(log.Result)).AppendLine();
                }
            }
            return sb.ToString();
        }

        /// <summary>导出 CSV 文件（UTF-8 带 BOM，Excel 打开不乱码）</summary>
        public static void ExportCsv(string filePath, List<LogEntry> logs)
        {
            File.WriteAllText(filePath, BuildCsv(logs), new UTF8Encoding(true));
        }

        private static string Escape(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            if (value.IndexOfAny(new[] { ',', '"', '\r', '\n' }) < 0) return value;
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
    }
}
