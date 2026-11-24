using CCWin;
using EPCMS.BLL;
using EPCMS.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EPCMS.Views
{
    /// <summary>
    /// 操作日志管理界面：筛选、分页、导出、清理、查看详情
    /// </summary>
    public partial class LogForm : Skin_Color
    {
        private readonly LogService _logService;
        private int _page = 1;
        private int _pageSize = 20;
        private int _pageCount = 1;
        private int _total;
        private bool _loaded;

        public LogForm(LogService logService)
        {
            InitializeComponent();
            _logService = logService;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Now;
            cboAction.SelectedIndex = 0;
            cboPageSize.SelectedIndex = 0;
            _loaded = true;
            LoadPage(1);
        }

        private string CurrentAction
        {
            get { return cboAction.SelectedIndex <= 0 ? "" : cboAction.Text; }
        }

        private string CurrentKeyword
        {
            get { return txtKeyword.Text.Trim(); }
        }

        private DateTime QueryFrom
        {
            get { return dtpFrom.Value.Date; }
        }

        private DateTime QueryTo
        {
            get { return dtpTo.Value.Date.AddDays(1).AddSeconds(-1); }
        }

        private void LoadPage(int page)
        {
            if (!_loaded) return;
            if (QueryFrom > QueryTo)
            {
                MessageBox.Show("开始时间不能晚于结束时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Cursor = Cursors.WaitCursor;
                _pageSize = int.Parse(cboPageSize.Text);
                _total = _logService.Count(QueryFrom, QueryTo, CurrentAction, CurrentKeyword);
                _pageCount = Math.Max(1, (_total + _pageSize - 1) / _pageSize);
                _page = Math.Min(Math.Max(1, page), _pageCount);

                dgvLog.DataSource = _logService.QueryPage(QueryFrom, QueryTo, CurrentAction, CurrentKeyword, _page, _pageSize);
                lblPage.Text = string.Format("第 {0}/{1} 页", _page, _pageCount);
                lblTotal.Text = string.Format("共 {0} 条", _total);
                btnPrev.Enabled = _page > 1;
                btnNext.Enabled = _page < _pageCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询日志失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadPage(1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Now;
            cboAction.SelectedIndex = 0;
            txtKeyword.Text = "";
            LoadPage(1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            LoadPage(_page - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadPage(_page + 1);
        }

        private void cboPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPage(1);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var list = _logService.QueryAll(QueryFrom, QueryTo, CurrentAction, CurrentKeyword);
                if (list.Count == 0)
                {
                    MessageBox.Show("当前条件下没有可导出的日志", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                using (var dialog = new SaveFileDialog())
                {
                    dialog.Filter = "CSV 文件(*.csv)|*.csv";
                    dialog.FileName = "操作日志_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                    if (dialog.ShowDialog(this) != DialogResult.OK) return;
                    LogService.ExportCsv(dialog.FileName, list);
                }
                _logService.Write("日志", "导出", string.Format("导出日志 {0} 条", list.Count));
                MessageBox.Show("导出完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            int days = (int)numDays.Value;
            if (MessageBox.Show(string.Format("确定清理 {0} 天前的日志吗？此操作不可恢复。", days), "确认清理",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            try
            {
                int count = _logService.CleanBefore(days);
                _logService.Write("日志", "清理", string.Format("清理 {0} 天前的日志，共 {1} 条", days, count));
                MessageBox.Show(string.Format("已清理 {0} 条", count), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPage(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("清理失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var log = dgvLog.Rows[e.RowIndex].DataBoundItem as LogEntry;
            if (log == null) return;
            MessageBox.Show(string.Format("时间：{0}\r\n操作人：{1}\r\n模块：{2}\r\n操作：{3}\r\n结果：{4}\r\n\r\n{5}",
                log.LogTime, log.UserName, log.Module, log.ActionType, log.Result, log.Detail), "日志详情");
        }
    }
}
