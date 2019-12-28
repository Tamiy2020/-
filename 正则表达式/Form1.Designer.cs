namespace 正则表达式
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
            this.txt_Regex = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_Tips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Regex
            // 
            this.txt_Regex.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Regex.Location = new System.Drawing.Point(24, 74);
            this.txt_Regex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Regex.MaxLength = 6;
            this.txt_Regex.Name = "txt_Regex";
            this.txt_Regex.PasswordChar = '●';
            this.txt_Regex.Size = new System.Drawing.Size(116, 23);
            this.txt_Regex.TabIndex = 0;
            this.txt_Regex.TextChanged += new System.EventHandler(this.txt_Regex_TextChanged);
            this.txt_Regex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Regex_KeyDown);
            // 
            // btn_OK
            // 
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(169, 74);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Tips
            // 
            this.lbl_Tips.AutoSize = true;
            this.lbl_Tips.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tips.Location = new System.Drawing.Point(24, 41);
            this.lbl_Tips.Name = "lbl_Tips";
            this.lbl_Tips.Size = new System.Drawing.Size(0, 17);
            this.lbl_Tips.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(262, 131);
            this.Controls.Add(this.lbl_Tips);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Regex);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码（正则表达式的应用）";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Regex;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_Tips;
    }
}

