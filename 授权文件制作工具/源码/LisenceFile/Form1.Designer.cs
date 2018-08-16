namespace LisenceFile
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxVersions = new System.Windows.Forms.ComboBox();
            this.btnVersionSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cbxAuthoTypes = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSignDate = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersionNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxVersions
            // 
            this.cbxVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVersions.FormattingEnabled = true;
            this.cbxVersions.Location = new System.Drawing.Point(27, 30);
            this.cbxVersions.Name = "cbxVersions";
            this.cbxVersions.Size = new System.Drawing.Size(322, 20);
            this.cbxVersions.TabIndex = 1;
            this.cbxVersions.SelectedIndexChanged += new System.EventHandler(this.cbxVersions_SelectedIndexChanged);
            // 
            // btnVersionSettings
            // 
            this.btnVersionSettings.Location = new System.Drawing.Point(385, 25);
            this.btnVersionSettings.Name = "btnVersionSettings";
            this.btnVersionSettings.Size = new System.Drawing.Size(75, 23);
            this.btnVersionSettings.TabIndex = 2;
            this.btnVersionSettings.Text = "版本管理";
            this.btnVersionSettings.UseVisualStyleBackColor = true;
            this.btnVersionSettings.Click += new System.EventHandler(this.btnVisionSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVersionNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxVersions);
            this.groupBox1.Controls.Add(this.btnVersionSettings);
            this.groupBox1.Location = new System.Drawing.Point(19, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(594, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "版本类型";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMemo);
            this.groupBox3.Controls.Add(this.txtContent);
            this.groupBox3.Controls.Add(this.cbxAuthoTypes);
            this.groupBox3.Location = new System.Drawing.Point(19, 214);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(594, 184);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "授权方式";
            // 
            // lblMemo
            // 
            this.lblMemo.Location = new System.Drawing.Point(406, 59);
            this.lblMemo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(172, 112);
            this.lblMemo.TabIndex = 2;
            this.lblMemo.Text = "label1";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(28, 57);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(363, 115);
            this.txtContent.TabIndex = 1;
            // 
            // cbxAuthoTypes
            // 
            this.cbxAuthoTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuthoTypes.FormattingEnabled = true;
            this.cbxAuthoTypes.Location = new System.Drawing.Point(28, 29);
            this.cbxAuthoTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxAuthoTypes.Name = "cbxAuthoTypes";
            this.cbxAuthoTypes.Size = new System.Drawing.Size(150, 20);
            this.cbxAuthoTypes.TabIndex = 0;
            this.cbxAuthoTypes.SelectedIndexChanged += new System.EventHandler(this.cbxAuthoTypes_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(19, 411);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(63, 24);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "加载授权";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(458, 417);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 24);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存授权";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(550, 417);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 24);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "签名日期";
            // 
            // txtSignDate
            // 
            this.txtSignDate.Enabled = false;
            this.txtSignDate.Location = new System.Drawing.Point(86, 13);
            this.txtSignDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSignDate.Name = "txtSignDate";
            this.txtSignDate.Size = new System.Drawing.Size(281, 21);
            this.txtSignDate.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(547, 13);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "使用帮助";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "版本识别号";
            // 
            // txtVersionNo
            // 
            this.txtVersionNo.Location = new System.Drawing.Point(99, 81);
            this.txtVersionNo.Name = "txtVersionNo";
            this.txtVersionNo.ReadOnly = true;
            this.txtVersionNo.Size = new System.Drawing.Size(249, 21);
            this.txtVersionNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(383, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "这个写在客户端代码中";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 455);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtSignDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成授权文件";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxVersions;
        private System.Windows.Forms.Button btnVersionSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cbxAuthoTypes;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSignDate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtVersionNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

