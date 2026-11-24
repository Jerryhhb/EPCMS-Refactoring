using CCWin;
using EPCMS.BLL;
using EPCMS.DAL;
using EPCMS.Models;
using EPCMS.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPCMS.Views
{
    public partial class EditForm : Skin_Color
    {
        // 1. 在类级别，只声明变量
        private Services _services;

        public Devices device { get; set; }//设备实体属性,导入编辑界面

        /// <summary>保存成功后带回给主界面的实体（用于写操作日志）</summary>
        public Devices SavedDevice { get; private set; }

        public EditForm(Services service)
        {
            InitializeComponent();

            // 再把工具类传给业务层
            _services = service;
        }

        private void EditForm_Load(object sender, EventArgs e)//编辑窗体初始加载
        {
            if(device!=null)//修改模式
            {
                txtDeviceID.Text=device.DeviceID.ToString();
                txtDeviceName.Text = device.DeviceName;
                txtDeviceType.Text = device.DeviceType;
                txtDeviceLocation.Text = device.Location;
                txtDeviceID.ReadOnly = true;//只读模式


            }
            else//新增模式
            {
                txtDeviceID.Text = "";
                txtDeviceName.Text = "";
                txtDeviceType.Text = "";
                txtDeviceLocation.Text = "";
                txtDeviceID.ReadOnly = true;//只读模式

            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            // 简单校验
            if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                MessageBox.Show("设备名称不能为空", "提示");
                return;
            }
            btnSave.Enabled = false;

            try
            {
                var d = new Devices
                {
                    DeviceID = device != null ? device.DeviceID : 0,   // 修改时要带上ID
                    DeviceName = txtDeviceName.Text,
                    DeviceType = txtDeviceType.Text,
                    Location = txtDeviceLocation.Text,
                };
                if(device!=null)//修改模式
                {
                    await _services.UpdateDataAsync(d);
                }
                else//新增模式
                {
                    await _services.InsertDataAsync(d);
                }
                SavedDevice = d;
                // 告诉主界面“保存成功”，主界面会刷新列表
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("保存失败：" + ex.Message, "错误");
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
