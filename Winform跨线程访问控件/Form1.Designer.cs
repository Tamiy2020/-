namespace Winform跨线程访问控件
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Suspend = new System.Windows.Forms.Button();
            this.btn_Resume = new System.Windows.Forms.Button();
            this.lbl_Show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Start.Location = new System.Drawing.Point(35, 33);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "开始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Suspend
            // 
            this.btn_Suspend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Suspend.Enabled = false;
            this.btn_Suspend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Suspend.Location = new System.Drawing.Point(157, 33);
            this.btn_Suspend.Name = "btn_Suspend";
            this.btn_Suspend.Size = new System.Drawing.Size(75, 23);
            this.btn_Suspend.TabIndex = 1;
            this.btn_Suspend.Text = "暂停";
            this.btn_Suspend.UseVisualStyleBackColor = true;
            this.btn_Suspend.Click += new System.EventHandler(this.btn_Suspend_Click);
            // 
            // btn_Resume
            // 
            this.btn_Resume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Resume.Enabled = false;
            this.btn_Resume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Resume.Location = new System.Drawing.Point(279, 33);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.Size = new System.Drawing.Size(75, 23);
            this.btn_Resume.TabIndex = 2;
            this.btn_Resume.Text = "继续";
            this.btn_Resume.UseVisualStyleBackColor = true;
            this.btn_Resume.Click += new System.EventHandler(this.btn_Resume_Click);
            // 
            // lbl_Show
            // 
            this.lbl_Show.AutoSize = true;
            this.lbl_Show.ForeColor = System.Drawing.Color.Red;
            this.lbl_Show.Location = new System.Drawing.Point(32, 75);
            this.lbl_Show.Name = "lbl_Show";
            this.lbl_Show.Size = new System.Drawing.Size(26, 17);
            this.lbl_Show.TabIndex = 3;
            this.lbl_Show.Text = "......";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(423, 284);
            this.Controls.Add(this.lbl_Show);
            this.Controls.Add(this.btn_Resume);
            this.Controls.Add(this.btn_Suspend);
            this.Controls.Add(this.btn_Start);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "跨线程访问控件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Suspend;
        private System.Windows.Forms.Button btn_Resume;
        private System.Windows.Forms.Label lbl_Show;
    }
}

