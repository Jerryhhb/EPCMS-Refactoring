namespace EPCMS
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new CCWin.SkinControl.SkinButton();
            this.btnModify = new CCWin.SkinControl.SkinButton();
            this.btnAdd = new CCWin.SkinControl.SkinButton();
            this.dgvDevice = new CCWin.SkinControl.SkinDataGridView();
            this.btnSearch = new CCWin.SkinControl.SkinButton();
            this.txtDeviceName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsbLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Red;
            this.btnDelete.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDelete.DownBack = null;
            this.btnDelete.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(646, 445);
            this.btnDelete.MouseBack = null;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormlBack = null;
            this.btnDelete.Size = new System.Drawing.Size(112, 46);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.BaseColor = System.Drawing.Color.Yellow;
            this.btnModify.BorderColor = System.Drawing.Color.Yellow;
            this.btnModify.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnModify.DownBack = null;
            this.btnModify.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModify.Location = new System.Drawing.Point(338, 445);
            this.btnModify.MouseBack = null;
            this.btnModify.Name = "btnModify";
            this.btnModify.NormlBack = null;
            this.btnModify.Size = new System.Drawing.Size(112, 46);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Lime;
            this.btnAdd.BorderColor = System.Drawing.Color.Lime;
            this.btnAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdd.DownBack = null;
            this.btnAdd.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(48, 445);
            this.btnAdd.MouseBack = null;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormlBack = null;
            this.btnAdd.Size = new System.Drawing.Size(112, 46);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDevice
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvDevice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDevice.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDevice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDevice.ColumnFont = null;
            this.dgvDevice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevice.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDevice.EnableHeadersVisualStyles = false;
            this.dgvDevice.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDevice.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvDevice.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDevice.Location = new System.Drawing.Point(48, 154);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDevice.RowHeadersWidth = 62;
            this.dgvDevice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDevice.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.Size = new System.Drawing.Size(710, 268);
            this.dgvDevice.TabIndex = 10;
            this.dgvDevice.TitleBack = null;
            this.dgvDevice.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvDevice.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSearch.DownBack = null;
            this.btnSearch.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(646, 70);
            this.btnSearch.MouseBack = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormlBack = null;
            this.btnSearch.Size = new System.Drawing.Size(112, 46);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.BackColor = System.Drawing.Color.Transparent;
            this.txtDeviceName.DownBack = null;
            this.txtDeviceName.Icon = null;
            this.txtDeviceName.IconIsButton = false;
            this.txtDeviceName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDeviceName.IsPasswordChat = '\0';
            this.txtDeviceName.IsSystemPasswordChar = false;
            this.txtDeviceName.Lines = new string[0];
            this.txtDeviceName.Location = new System.Drawing.Point(180, 70);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(0);
            this.txtDeviceName.MaxLength = 32767;
            this.txtDeviceName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDeviceName.MouseBack = null;
            this.txtDeviceName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDeviceName.Multiline = true;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.NormlBack = null;
            this.txtDeviceName.Padding = new System.Windows.Forms.Padding(5);
            this.txtDeviceName.ReadOnly = false;
            this.txtDeviceName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeviceName.Size = new System.Drawing.Size(413, 50);
            // 
            // 
            // 
            this.txtDeviceName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeviceName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeviceName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeviceName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDeviceName.SkinTxt.Multiline = true;
            this.txtDeviceName.SkinTxt.Name = "BaseText";
            this.txtDeviceName.SkinTxt.Size = new System.Drawing.Size(403, 40);
            this.txtDeviceName.SkinTxt.TabIndex = 0;
            this.txtDeviceName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDeviceName.SkinTxt.WaterText = "";
            this.txtDeviceName.TabIndex = 8;
            this.txtDeviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeviceName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDeviceName.WaterText = "";
            this.txtDeviceName.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(42, 75);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(134, 36);
            this.skinLabel1.TabIndex = 7;
            this.skinLabel1.Text = "设备名称:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLog,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(8, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 37);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsbLog
            // 
            this.tsbLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLog.Name = "tsbLog";
            this.tsbLog.Size = new System.Drawing.Size(76, 34);
            this.tsbLog.Text = "日志管理";
            this.tsbLog.ToolTipText = "查看操作日志";
            this.tsbLog.Click += new System.EventHandler(this.tsbLog_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 30);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDevice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.skinLabel1);
            this.Name = "MainForm";
            this.Text = "设备管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnDelete;
        private CCWin.SkinControl.SkinButton btnModify;
        private CCWin.SkinControl.SkinButton btnAdd;
        private CCWin.SkinControl.SkinDataGridView dgvDevice;
        private CCWin.SkinControl.SkinButton btnSearch;
        private CCWin.SkinControl.SkinTextBox txtDeviceName;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton tsbLog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
