using Dapper;            //轻量级数据库工具
using EPCMS.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite; //SQLite数据库

namespace EPCMS.DAL
{
    public class SQLHelper : IDbHelper //继承功能接口
    {
        private readonly string _dbPath; //路径

        private readonly string _connstr; //连接字符串

        public SQLHelper(string dbPath)
        {
            _dbPath = dbPath;
            _connstr = $"Data Source={_dbPath};Version=3;";
            InitDB();
        }

        // 返回数据库连接路径
        public SQLiteConnection CreateConnection()
        {
            return new SQLiteConnection(_connstr);
        }

        //数据库初始化与连接
        private void InitDB()
        {
            using (var conn = CreateConnection())
            {
                conn.Open();

                //设备表
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS ShopDevice(
                        DeviceID INTEGER PRIMARY KEY AUTOINCREMENT,
                        DeviceName TEXT NOT NULL,
                        DeviceType TEXT NOT NULL,
                        Location TEXT);";
                    command.ExecuteNonQuery();
                }

                //操作日志表
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS OperationLog(
                        LogID INTEGER PRIMARY KEY AUTOINCREMENT,
                        LogTime TEXT NOT NULL,
                        UserName TEXT,
                        Module TEXT,
                        ActionType TEXT,
                        Detail TEXT,
                        Result TEXT);";
                    command.ExecuteNonQuery();
                }

                //按时间查日志的索引
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "CREATE INDEX IF NOT EXISTS IX_OperationLog_LogTime ON OperationLog(LogTime);";
                    command.ExecuteNonQuery();
                }
            }
        }

        // 继承的功能1 查询数据,返回列表
        public List<T> SelectData<T>(string sql, object parameters = null)
        {
            using (var conn = CreateConnection())
            {
                return conn.Query<T>(sql, parameters).AsList();
            }
        }

        // 继承的功能2 增删改数据,返回更改的行数
        public int EditData(string sql, object parameters = null)
        {
            using (var conn = CreateConnection())
            {
                return conn.Execute(sql, parameters);
            }
        }
    }
}
