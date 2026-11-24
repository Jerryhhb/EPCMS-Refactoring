namespace EPCMS.Views
{
    partial class LogForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblAction = new System.Windows.Forms.Label();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnQuery = new CCWin.SkinControl.SkinButton();
            this.btnReset = new CCWin.SkinControl.SkinButton();
            this.lblDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.btnClean = new CCWin.SkinControl.SkinButton();
            this.btnExport = new CCWin.SkinControl.SkinButton();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnPrev = new CCWin.SkinControl.SkinButton();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new CCWin.SkinControl.SkinButton();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.cboPageSize = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblFrom);
            this.panelTop.Controls.Add(this.dtpFrom);
            this.panelTop.Controls.Add(this.lblTo);
            this.panelTop.Controls.Add(this.dtpTo);
            this.panelTop.Controls.Add(this.lblAction);
            this.panelTop.Controls.Add(this.cboAction);
            this.panelTop.Controls.Add(this.lblKeyword);
            this.panelTop.Controls.Add(this.txtKeyword);
            this.panelTop.Controls.Add(this.btnQuery);
            this.panelTop.Controls.Add(this.btnReset);
            this.panelTop.Controls.Add(this.lblDays);
            this.panelTop.Controls.Add(this.numDays);
            this.panelTop.Controls.Add(this.btnClean);
            this.panelTop.Controls.Add(this.btnExport);
            this.panelTop.Location = new System.Drawing.Point(12, 52);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(986, 96);
            this.panelTop.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 19);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(53, 18);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "时间:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(66, 14);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(150, 28);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(222, 19);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 18);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "至";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(256, 15);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 28);
            this.dtpTo.TabIndex = 3;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(412, 19);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(53, 18);
            this.lblAction.TabIndex = 4;
            this.lblAction.Text = "类型:";
            // 
            // cboAction
            // 
            this.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAction.Items.AddRange(new object[] {
            "全部",
            "启动",
            "退出",
            "新增",
            "修改",
            "删除",
            "查询",
            "导出",
            "清理",
            "异常"});
            this.cboAction.Location = new System.Drawing.Point(471, 17);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(140, 26);
            this.cboAction.TabIndex = 5;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(609, 21);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(71, 18);
            this.lblKeyword.TabIndex = 6;
            this.lblKeyword.Text = "关键字:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(698, 14);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(160, 28);
            this.txtKeyword.TabIndex = 7;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.BaseColor = System.Drawing.Color.Lime;
            this.btnQuery.BorderColor = System.Drawing.Color.Lime;
            this.btnQuery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQuery.DownBack = null;
            this.btnQuery.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(901, 57);
            this.btnQuery.MouseBack = null;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.NormlBack = null;
            this.btnQuery.Size = new System.Drawing.Size(80, 30);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BaseColor = System.Drawing.Color.White;
            this.btnReset.BorderColor = System.Drawing.Color.Gray;
            this.btnReset.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnReset.DownBack = null;
            this.btnReset.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(901, 12);
            this.btnReset.MouseBack = null;
            this.btnReset.Name = "btnReset";
            this.btnReset.NormlBack = null;
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(12, 61);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(89, 18);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "保留天数:";
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(107, 57);
            this.numDays.Maximum = new decimal(new int[] {
            3650,
            0,
            0,
            0});
            this.numDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(58, 28);
            this.numDays.TabIndex = 2;
            this.numDays.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.BaseColor = System.Drawing.Color.Red;
            this.btnClean.BorderColor = System.Drawing.Color.Red;
            this.btnClean.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClean.DownBack = null;
            this.btnClean.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClean.Location = new System.Drawing.Point(200, 53);
            this.btnClean.MouseBack = null;
            this.btnClean.Name = "btnClean";
            this.btnClean.NormlBack = null;
            this.btnClean.Size = new System.Drawing.Size(115, 30);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "清理";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BaseColor = System.Drawing.Color.Yellow;
            this.btnExport.BorderColor = System.Drawing.Color.Yellow;
            this.btnExport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnExport.DownBack = null;
            this.btnExport.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(332, 51);
            this.btnExport.MouseBack = null;
            this.btnExport.Name = "btnExport";
            this.btnExport.NormlBack = null;
            this.btnExport.Size = new System.Drawing.Size(133, 30);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(12, 154);
            this.dgvLog.MultiSelect = false;
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowHeadersWidth = 62;
            this.dgvLog.RowTemplate.Height = 26;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(986, 467);
            this.dgvLog.TabIndex = 5;
            this.dgvLog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLog_CellDoubleClick);
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.Controls.Add(this.btnPrev);
            this.panelBottom.Controls.Add(this.lblPage);
            this.panelBottom.Controls.Add(this.btnNext);
            this.panelBottom.Controls.Add(this.lblPageSize);
            this.panelBottom.Controls.Add(this.cboPageSize);
            this.panelBottom.Controls.Add(this.lblTotal);
            this.panelBottom.Location = new System.Drawing.Point(12, 631);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(986, 44);
            this.panelBottom.TabIndex = 6;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BaseColor = System.Drawing.Color.White;
            this.btnPrev.BorderColor = System.Drawing.Color.Gray;
            this.btnPrev.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPrev.DownBack = null;
            this.btnPrev.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrev.Location = new System.Drawing.Point(0, 6);
            this.btnPrev.MouseBack = null;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.NormlBack = null;
            this.btnPrev.Size = new System.Drawing.Size(101, 30);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(114, 13);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(89, 18);
            this.lblPage.TabIndex = 1;
            this.lblPage.Text = "第 1/1 页";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BaseColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.Gray;
            this.btnNext.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnNext.DownBack = null;
            this.btnNext.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(219, 6);
            this.btnNext.MouseBack = null;
            this.btnNext.Name = "btnNext";
            this.btnNext.NormlBack = null;
            this.btnNext.Size = new System.Drawing.Size(94, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Location = new System.Drawing.Point(319, 13);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(53, 18);
            this.lblPageSize.TabIndex = 2;
            this.lblPageSize.Text = "每页:";
            // 
            // cboPageSize
            // 
            this.cboPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPageSize.Items.AddRange(new object[] {
            "20",
            "50",
            "100"});
            this.cboPageSize.Location = new System.Drawing.Point(395, 10);
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Size = new System.Drawing.Size(70, 26);
            this.cboPageSize.TabIndex = 3;
            this.cboPageSize.SelectedIndexChanged += new System.EventHandler(this.cboPageSize_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(910, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "共 0 条";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 693);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.panelBottom);
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "操作日志";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private CCWin.SkinControl.SkinButton btnQuery;
        private CCWin.SkinControl.SkinButton btnReset;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown numDays;
        private CCWin.SkinControl.SkinButton btnClean;
        private CCWin.SkinControl.SkinButton btnExport;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.Panel panelBottom;
        private CCWin.SkinControl.SkinButton btnPrev;
        private System.Windows.Forms.Label lblPage;
        private CCWin.SkinControl.SkinButton btnNext;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.ComboBox cboPageSize;
        private System.Windows.Forms.Label lblTotal;
    }
}
