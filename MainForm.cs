using CCWin;
using EPCMS.BLL;
using EPCMS.DAL;
using EPCMS.Models;
using EPCMS.Views;
using System;
using System.IO;
using System.Windows.Forms;

namespace EPCMS
{
    public partial class MainForm : Skin_Color
    {
        // 在类级别，只声明数据库帮助类 及 业务类
        private readonly SQLHelper _sqlhelper;
        private readonly Services _services;
        private readonly LogService _logService;

        private readonly string _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EPCMSDB.db");

        public MainForm(LogService logService)
        {
            InitializeComponent();
            _logService = logService;
            // 先创建工具类
            _sqlhelper = new SQLHelper(_dbPath);
            // 再把工具类传给业务层
            _services = new Services(_sqlhelper);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _logService.Write("系统", "启动", "进入主界面");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logService.Write("系统", "退出", "设备管理系统关闭");
        }

        //查询按钮
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                MessageBox.Show("请输入设备名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSearch.Enabled = false;
            try
            {
                string deviceName = txtDeviceName.Text.Trim();
                var list = await _services.SelectDataAsync(deviceName);
                _logService.Write("设备", "查询", $"查询设备：{deviceName}，命中 {list.Count} 条");
                if (list.Count <= 0)
                {
                    MessageBox.Show("无此设备数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvDevice.DataSource = list;
                toolStripStatusLabel1.Text = $"共 {list.Count} 条记录";
            }
            catch (Exception ex)
            {
                _logService.Write("设备", "查询", $"查询设备「{txtDeviceName.Text.Trim()}」失败：{ex.Message}", "失败");
                MessageBox.Show($"查询数据失败:{ex.Message}", "错误");
            }
            finally
            {
                btnSearch.Enabled = true;
            }
        }

        //添加按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(_services);
            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                var device = editForm.SavedDevice;
                _logService.Write("设备", "新增", device == null
                    ? "新增设备"
                    : $"新增设备：{device.DeviceName}（类型：{device.DeviceType}，位置：{device.Location}）");
                //自动刷新
                btnSearch.PerformClick();
            }
        }

        //修改按钮
        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvDevice.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnModify.Enabled = false;   //防止重复点击
            try
            {
                int deviceID = (int)dgvDevice.SelectedRows[0].Cells["DeviceID"].Value;
                var list = await _services.GetByIDAsync(deviceID);
                if (list.Count > 0)
                {
                    Devices deviceGetby = list[0]; //传入搜索第一张对象
                    EditForm editForm = new EditForm(_services); // 把业务层直接注入给子窗体
                    editForm.device = deviceGetby;//导入编辑界面
                    if (editForm.ShowDialog(this) == DialogResult.OK)
                    {
                        var device = editForm.SavedDevice;
                        _logService.Write("设备", "修改", device == null
                            ? $"修改设备编号 {deviceID}"
                            : $"修改设备：{device.DeviceName}（编号 {device.DeviceID}，类型：{device.DeviceType}，位置：{device.Location}）");
                        btnSearch.PerformClick();//自我刷新
                    }
                }
            }
            catch (Exception ex)
            {
                _logService.Write("设备", "修改", $"修改设备编号 {dgvDevice.SelectedRows[0].Cells["DeviceID"].Value} 失败：{ex.Message}", "失败");
                MessageBox.Show($"无法修改:{ex.Message}!", "提示");
            }
            finally
            {
                btnModify.Enabled = true;  //恢复点击
            }
        }

        //删除按钮
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDevice.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnDelete.Enabled = false;
            try
            {
                int deviceID = (int)dgvDevice.SelectedRows[0].Cells["DeviceID"].Value;
                string deviceName = dgvDevice.SelectedRows[0].Cells["DeviceName"].Value.ToString();

                DialogResult result = MessageBox.Show($"确定删除{deviceName}吗?", "确认删除", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    return;
                }
                var count = await _services.DeleteDataAsync(deviceID);
                if (count > 0)
                {
                    _logService.Write("设备", "删除", $"删除设备：{deviceName}（编号 {deviceID}）");
                    btnSearch.PerformClick();
                }
                else
                {
                    _logService.Write("设备", "删除", $"删除设备：{deviceName}（编号 {deviceID}）失败，未找到记录", "失败");
                    MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法删除:{ex.Message}!", "提示");
            }
            finally
            {
                btnDelete.Enabled = true;
            }
        }

        //日志管理
        private void tsbLog_Click(object sender, EventArgs e)
        {
            using (var logForm = new LogForm(_logService))
            {
                logForm.ShowDialog(this);
            }
        }
    }
}
