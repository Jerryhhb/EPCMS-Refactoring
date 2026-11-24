using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCMS.Models
{
    public class Devices //添加实体类
    {
        public int DeviceID { get; set; }//设备编号

        public string DeviceName { get; set; } //设备名称

        public string DeviceType { get; set; }//设备类型

        public string Location { get; set; } //设备地址

    }
}
