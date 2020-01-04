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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Resume = new System.Windows.Forms.Button();
            this.lbl_Show = new System.Windows.Forms.Label();
            this.btn_Suspend = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_Progress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Resume);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Show);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Suspend);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Start);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(475, 309);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Resume
            // 
            this.btn_Resume.Enabled = false;
            this.btn_Resume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Resume.Location = new System.Drawing.Point(321, 40);
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
            this.lbl_Show.Location = new System.Drawing.Point(50, 83);
            this.lbl_Show.Name = "lbl_Show";
            this.lbl_Show.Size = new System.Drawing.Size(26, 17);
            this.lbl_Show.TabIndex = 11;
            this.lbl_Show.Text = "......";
            // 
            // btn_Suspend
            // 
            this.btn_Suspend.Enabled = false;
            this.btn_Suspend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Suspend.Location = new System.Drawing.Point(187, 41);
            this.btn_Suspend.Name = "btn_Suspend";
            this.btn_Suspend.Size = new System.Drawing.Size(75, 23);
            this.btn_Suspend.TabIndex = 1;
            this.btn_Suspend.Text = "暂停";
            this.btn_Suspend.UseVisualStyleBackColor = true;
            this.btn_Suspend.Click += new System.EventHandler(this.btn_Suspend_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Start.Location = new System.Drawing.Point(53, 41);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "开始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Progress);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Controls.Add(this.btn_Pause);
            this.groupBox1.Controls.Add(this.btn_Run);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BackgroundWorker使用范例";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btn_Run
            // 
            this.btn_Run.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Run.Location = new System.Drawing.Point(53, 48);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 6;
            this.btn_Run.Text = "启动";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Pause.Location = new System.Drawing.Point(187, 48);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(75, 23);
            this.btn_Pause.TabIndex = 7;
            this.btn_Pause.Text = "暂停";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Stop.Location = new System.Drawing.Point(321, 48);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 8;
            this.btn_Stop.Text = "停止";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "执行进度：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(53, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(343, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Progress.Location = new System.Drawing.Point(127, 97);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(36, 17);
            this.lbl_Progress.TabIndex = 5;
            this.lbl_Progress.Text = "0000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 309);
            this.Controls.Add(this.splitContainer1);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_Show;
        private System.Windows.Forms.Button btn_Suspend;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Resume;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Run;
    }
}

