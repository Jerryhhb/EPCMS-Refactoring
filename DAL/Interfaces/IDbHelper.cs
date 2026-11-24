using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCMS.DAL.Interfaces
{
      public interface IDbHelper //数据库功能接口 查表+编辑表两个方法
        {
            List<T> SelectData<T>(string sql, object parameters = null);
            int EditData(string sql, object parameters = null);
        }

}
