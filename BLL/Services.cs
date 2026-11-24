using EPCMS.DAL;
using EPCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace EPCMS.BLL
{
    public class Services
    {
        //1.声明一个私有数据库工具变量
        private readonly SQLHelper _sqlHelper;
        //2. 通过构造函数，在创建 Service 时把工具箱塞进去（这叫依赖注入）

        public Services(SQLHelper sqlHelper)
        {
            _sqlHelper = sqlHelper;
        }

        //以下为各种业务逻辑

        //查询数据
        public async Task<List<Devices>> SelectDataAsync(string deviceName)
        {
            string sql = "SELECT * FROM shopdevice WHERE DeviceName Like @name";

            var parameters = new { name = "%" + deviceName + "%" };

            // 利用 Task.Run 后台线程处理数据
            var list = await Task.Run(() =>
            {

                return _sqlHelper.SelectData<Devices>(sql, parameters);

            });

            return list;

        }

        // 删除数据
        public async  Task<int> DeleteDataAsync(int deviceID)
        {
            string sql = "DELETE FROM shopdevice WHERE DeviceID=@ID";
            var parameters = new { ID = deviceID.ToString() };
            int count = await Task.Run(() =>
            {
                return _sqlHelper.EditData(sql, parameters);
            });
            return count;
        }

        //按编号查询一条（编辑界面回填数据用）
        public async Task<List<Devices>> GetByIDAsync(int deviceID)
        {
            string sql = "SELECT * FROM shopdevice WHERE DeviceID = @ID";

            var parameters = new { ID = deviceID.ToString() };

            // 利用 Task.Run 后台线程处理数据
            var list = await Task.Run(() =>
            {

                return _sqlHelper.SelectData<Devices>(sql, parameters);

            });

            return list;

        }


        //新增数据
         public async Task InsertDataAsync(Devices d)
        {

            string sql = "INSERT INTO shopdevice (DeviceName, DeviceType, Location) " +
                         "VALUES (@DeviceName, @DeviceType, @Location)";
            await Task.Run(() =>
            {
                _sqlHelper.EditData(sql, d);
            });
        }


        //修改数据

        public async Task UpdateDataAsync(Devices d)
        {
            string sql = "UPDATE shopdevice SET DeviceName=@DeviceName, DeviceType=@DeviceType, " +
                         "Location=@Location  WHERE DeviceID=@DeviceID";
             await Task.Run(() =>
            {
                 _sqlHelper.EditData(sql, d);
            });

        }
    }
}
