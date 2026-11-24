using Dapper;
using EPCMS.DAL.Interfaces;
using EPCMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPCMS.DAL
{
    /// <summary>
    /// 日志数据访问层：只负责 OperationLog 表的读写，业务规则放在 BLL
    /// </summary>
    public class LogRepository
    {
        private readonly IDbHelper _db;

        public LogRepository(IDbHelper db)
        {
            _db = db;
        }

        /// <summary>写入一条日志</summary>
        public int Insert(LogEntry log)
        {
            const string sql = @"INSERT INTO OperationLog (LogTime, UserName, Module, ActionType, Detail, Result)
                                 VALUES (@LogTime, @UserName, @Module, @ActionType, @Detail, @Result)";
            return _db.EditData(sql, log);
        }

        /// <summary>按条件统计条数</summary>
        public int Count(DateTime from, DateTime to, string actionType, string keyword)
        {
            var (where, parameters) = BuildFilter(from, to, actionType, keyword);
            var countSql = "SELECT COUNT(*) FROM OperationLog WHERE " + where;
            var list = _db.SelectData<int>(countSql, parameters);
            return list.Count > 0 ? list[0] : 0;
        }

        /// <summary>按条件分页查询（第 1 页开始）</summary>
        public List<LogEntry> QueryPage(DateTime from, DateTime to, string actionType, string keyword, int page, int pageSize)
        {
            var (where, parameters) = BuildFilter(from, to, actionType, keyword);
            parameters.Add("@take", pageSize);
            parameters.Add("@skip", (page - 1) * pageSize);
            string sql = "SELECT * FROM OperationLog WHERE " + where + " ORDER BY LogID DESC LIMIT @take OFFSET @skip";
            return _db.SelectData<LogEntry>(sql, parameters);
        }

        /// <summary>按条件查询全部（导出用）</summary>
        public List<LogEntry> QueryAll(DateTime from, DateTime to, string actionType, string keyword)
        {
            var (where, parameters) = BuildFilter(from, to, actionType, keyword);
            string sql = "SELECT * FROM OperationLog WHERE " + where + " ORDER BY LogID DESC";
            return _db.SelectData<LogEntry>(sql, parameters);
        }

        /// <summary>删除指定时间之前的日志，返回删除条数</summary>
        public int DeleteBefore(DateTime time)
        {
            const string sql = "DELETE FROM OperationLog WHERE LogTime < @time";
            return _db.EditData(sql, new { time = time.ToString("yyyy-MM-dd HH:mm:ss") });
        }

        /// <summary>清空全部日志，返回删除条数</summary>
        public int DeleteAll()
        {
            const string sql = "DELETE FROM OperationLog";
            return _db.EditData(sql);
        }

        /// <summary>拼公共的 where 条件（全部用参数，防注入）</summary>
        private (string where, DynamicParameters parameters) BuildFilter(DateTime from, DateTime to, string actionType, string keyword)
        {
            var sb = new StringBuilder();
            var p = new DynamicParameters();
            sb.Append("LogTime >= @from AND LogTime <= @to");
            p.Add("@from", from.ToString("yyyy-MM-dd HH:mm:ss"));
            p.Add("@to", to.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.Append(" AND (@action = '' OR ActionType = @action)");
            p.Add("@action", actionType ?? "");
            sb.Append(" AND (@keyword = '' OR Detail LIKE @keyword OR UserName LIKE @keyword OR Module LIKE @keyword OR Result LIKE @keyword)");
            p.Add("@keyword", string.IsNullOrWhiteSpace(keyword) ? "" : "%" + keyword.Trim() + "%");
            return (sb.ToString(), p);
        }
    }
}
