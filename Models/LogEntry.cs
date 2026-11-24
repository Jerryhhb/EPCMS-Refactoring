using System;

namespace EPCMS.Models
{
    /// <summary>
    /// 操作日志实体，对应 OperationLog 表
    /// </summary>
    public class LogEntry
    {
        public long LogID { get; set; }        // 日志编号
        public string LogTime { get; set; }    // 时间 yyyy-MM-dd HH:mm:ss
        public string UserName { get; set; }   // 操作人
        public string Module { get; set; }     // 模块：设备/系统/日志
        public string ActionType { get; set; } // 操作类型：新增/修改/删除/查询/导出/清理/异常/启动/退出
        public string Detail { get; set; }     // 详细内容
        public string Result { get; set; }     // 结果：成功/失败
    }
}
