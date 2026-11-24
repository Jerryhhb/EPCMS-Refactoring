namespace EPCMS.Views
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDeviceID = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.txtDeviceLocation = new CCWin.SkinControl.SkinTextBox();
            this.txtDeviceType = new CCWin.SkinControl.SkinTextBox();
            this.txtDeviceName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.BackColor = System.Drawing.Color.Transparent;
            this.txtDeviceID.DownBack = null;
            this.txtDeviceID.Icon = null;
            this.txtDeviceID.IconIsButton = false;
            this.txtDeviceID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDeviceID.IsPasswordChat = '\0';
            this.txtDeviceID.IsSystemPasswordChar = false;
            this.txtDeviceID.Lines = new string[0];
            this.txtDeviceID.Location = new System.Drawing.Point(195, 85);
            this.txtDeviceID.Margin = new System.Windows.Forms.Padding(0);
            this.txtDeviceID.MaxLength = 32767;
            this.txtDeviceID.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDeviceID.MouseBack = null;
            this.txtDeviceID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDeviceID.Multiline = true;
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.NormlBack = null;
            this.txtDeviceID.Padding = new System.Windows.Forms.Padding(5);
            this.txtDeviceID.ReadOnly = false;
            this.txtDeviceID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeviceID.Size = new System.Drawing.Size(413, 50);
            // 
            // 
            // 
            this.txtDeviceID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeviceID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeviceID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeviceID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDeviceID.SkinTxt.Multiline = true;
            this.txtDeviceID.SkinTxt.Name = "BaseText";
            this.txtDeviceID.SkinTxt.Size = new System.Drawing.Size(403, 40);
            this.txtDeviceID.SkinTxt.TabIndex = 0;
            this.txtDeviceID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDeviceID.SkinTxt.WaterText = "";
            this.txtDeviceID.TabIndex = 29;
            this.txtDeviceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeviceID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDeviceID.WaterText = "";
            this.txtDeviceID.WordWrap = true;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(58, 85);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(134, 36);
            this.skinLabel6.TabIndex = 28;
            this.skinLabel6.Text = "设备编号:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.Aqua;
            this.btnSave.BorderColor = System.Drawing.Color.Aqua;
            this.btnSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSave.DownBack = null;
            this.btnSave.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(76, 450);
            this.btnSave.MouseBack = null;
            this.btnSave.Name = "btnSave";
            this.btnSave.NormlBack = null;
            this.btnSave.Size = new System.Drawing.Size(112, 46);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(494, 450);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(112, 46);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDeviceLocation
            // 
            this.txtDeviceLocation.BackColor = System.Drawing.Color.Transparent;
            this.txtDeviceLocation.DownBack = null;
            this.txtDeviceLocation.Icon = null;
            this.txtDeviceLocation.IconIsButton = false;
            this.txtDeviceLocation.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDeviceLocation.IsPasswordChat = '\0';
            this.txtDeviceLocation.IsSystemPasswordChar = false;
            this.txtDeviceLocation.Lines = new string[0];
            this.txtDeviceLocation.Location = new System.Drawing.Point(193, 338);
            this.txtDeviceLocation.Margin = new System.Windows.Forms.Padding(0);
            this.txtDeviceLocation.MaxLength = 32767;
            this.txtDeviceLocation.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDeviceLocation.MouseBack = null;
            this.txtDeviceLocation.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDeviceLocation.Multiline = true;
            this.txtDeviceLocation.Name = "txtDeviceLocation";
            this.txtDeviceLocation.NormlBack = null;
            this.txtDeviceLocation.Padding = new System.Windows.Forms.Padding(5);
            this.txtDeviceLocation.ReadOnly = false;
            this.txtDeviceLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeviceLocation.Size = new System.Drawing.Size(413, 50);
            // 
            // 
            // 
            this.txtDeviceLocation.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeviceLocation.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeviceLocation.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeviceLocation.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDeviceLocation.SkinTxt.Multiline = true;
            this.txtDeviceLocation.SkinTxt.Name = "BaseText";
            this.txtDeviceLocation.SkinTxt.Size = new System.Drawing.Size(403, 40);
            this.txtDeviceLocation.SkinTxt.TabIndex = 0;
            this.txtDeviceLocation.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDeviceLocation.SkinTxt.WaterText = "";
            this.txtDeviceLocation.TabIndex = 24;
            this.txtDeviceLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeviceLocation.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDeviceLocation.WaterText = "";
            this.txtDeviceLocation.WordWrap = true;
            // 
            // txtDeviceType
            // 
            this.txtDeviceType.BackColor = System.Drawing.Color.Transparent;
            this.txtDeviceType.DownBack = null;
            this.txtDeviceType.Icon = null;
            this.txtDeviceType.IconIsButton = false;
            this.txtDeviceType.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDeviceType.IsPasswordChat = '\0';
            this.txtDeviceType.IsSystemPasswordChar = false;
            this.txtDeviceType.Lines = new string[0];
            this.txtDeviceType.Location = new System.Drawing.Point(193, 256);
            this.txtDeviceType.Margin = new System.Windows.Forms.Padding(0);
            this.txtDeviceType.MaxLength = 32767;
            this.txtDeviceType.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDeviceType.MouseBack = null;
            this.txtDeviceType.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDeviceType.Multiline = true;
            this.txtDeviceType.Name = "txtDeviceType";
            this.txtDeviceType.NormlBack = null;
            this.txtDeviceType.Padding = new System.Windows.Forms.Padding(5);
            this.txtDeviceType.ReadOnly = false;
            this.txtDeviceType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeviceType.Size = new System.Drawing.Size(413, 50);
            // 
            // 
            // 
            this.txtDeviceType.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeviceType.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeviceType.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeviceType.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDeviceType.SkinTxt.Multiline = true;
            this.txtDeviceType.SkinTxt.Name = "BaseText";
            this.txtDeviceType.SkinTxt.Size = new System.Drawing.Size(403, 40);
            this.txtDeviceType.SkinTxt.TabIndex = 0;
            this.txtDeviceType.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDeviceType.SkinTxt.WaterText = "";
            this.txtDeviceType.TabIndex = 23;
            this.txtDeviceType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeviceType.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDeviceType.WaterText = "";
            this.txtDeviceType.WordWrap = true;
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
            this.txtDeviceName.Location = new System.Drawing.Point(193, 170);
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
            this.txtDeviceName.TabIndex = 21;
            this.txtDeviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeviceName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDeviceName.WaterText = "";
            this.txtDeviceName.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(54, 338);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(134, 36);
            this.skinLabel5.TabIndex = 20;
            this.skinLabel5.Text = "设备地址:";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(54, 262);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(134, 36);
            this.skinLabel4.TabIndex = 19;
            this.skinLabel4.Text = "设备类型:";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(56, 170);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(134, 36);
            this.skinLabel1.TabIndex = 16;
            this.skinLabel1.Text = "设备名称:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 545);
            this.Controls.Add(this.txtDeviceID);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDeviceLocation);
            this.Controls.Add(this.txtDeviceType);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel1);
            this.Name = "EditForm";
            this.Text = "编辑界面";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox txtDeviceID;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinButton btnSave;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinTextBox txtDeviceLocation;
        private CCWin.SkinControl.SkinTextBox txtDeviceType;
        private CCWin.SkinControl.SkinTextBox txtDeviceName;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
}