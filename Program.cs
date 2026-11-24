using EPCMS.BLL;
using EPCMS.DAL;
using System;
using System.IO;
using System.Windows.Forms;

namespace EPCMS
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 让 UI 线程的未处理异常走 ThreadException，而不是直接闪退
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            LogService logService = null;
            try
            {
                // 1. 先初始化数据库（建表）和日志服务
                var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EPCMSDB.db");
                var sqlHelper = new SQLHelper(dbPath);
                logService = new LogService(sqlHelper);
                logService.Write("系统", "启动", "设备管理系统启动");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库初始化失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. 全局异常：写日志 + 提示，避免「报错但不显示原因」
            Application.ThreadException += (sender, e) =>
            {
                logService.Write("系统", "异常", e.Exception.ToString(), "失败");
                MessageBox.Show("程序出现异常：" + e.Exception.Message + "\r\n详细信息已写入日志。", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var ex = e.ExceptionObject as Exception;
                logService.Write("系统", "异常", ex != null ? ex.ToString() : e.ExceptionObject.ToString(), "失败");
            };

            // 3. 启动主窗体
            Application.Run(new MainForm(logService));
        }
    }
}
