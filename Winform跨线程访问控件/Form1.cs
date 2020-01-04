using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform跨线程访问控件
{
    public partial class Form1 : Form
    {
        Thread t;
        int i = 0;
        private delegate void Agent();//②委托代理
        private ManualResetEvent manualReset = new ManualResetEvent(true);//线程状态对象，关键。
        public Form1()
        {
            InitializeComponent();
            // Control.CheckForIllegalCrossThreadCalls = false;//①禁止编译器对跨线程访问作检查（不安全）
        }

        private void Run()
        {
            i++;
            lbl_Show.Text = i.ToString();
        }

        private void Do()
        {
            while (true)
            {
                //Run();
                Doing();
            }
        }

        #region ②委托

        //private void Doing()
        //{
        //    if (lbl_Show.InvokeRequired)
        //    {
        //        Agent a = Doing; //new Agent(Doing);//回调
        //        //this.BeginInvoke(a);//异步调用
        //        this.Invoke(a);//同步调用
        //    }
        //    else
        //    {
        //        Run();
        //    }
        //} 


        //不使用委托
        //private void Doing()
        //{
        //    if (lbl_Show .InvokeRequired )
        //    {
        //        Action action = Run;
        //        this.Invoke(action);
        //    }
        //    else
        //    {
        //        Run();
        //    }
        //}

        //使用委托的Lambda表达式
        private void Doing()
        {
            // this.Invoke(new Action(() =>
            //{
            //    Run();
            //}
            // ));
            this.Invoke(new Action(Run));
        }
        #endregion

        private void btn_Start_Click(object sender, EventArgs e)
        {
            t = new Thread(Do); //new Thread(() => Do());
            t.IsBackground = true;
            t.Start();
            btn_Start.Enabled = false;
            btn_Suspend.Enabled = true;
        }

        [Obsolete]
        private void btn_Suspend_Click(object sender, EventArgs e)
        {
            t.Suspend();
            btn_Suspend.Enabled = false;
            btn_Resume.Enabled = true;
            //btn_Resume.Focus();
        }

        [Obsolete]
        private void btn_Resume_Click(object sender, EventArgs e)
        {
            t.Resume();
            btn_Suspend.Enabled = true;
            btn_Resume.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                t?.Abort();//中止线程
            }
            catch (Exception) { }
        }

        //-----------------------------------------------------------------------------------------------

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("用户取消了操作");
            }
            else
            {
                MessageBox.Show("正常完成了操作");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (backgroundWorker1.CancellationPending)//如果用户申请取消
                {
                    for (int k = i; k >= 0; k--)
                    {
                        Thread.Sleep(100);
                        backgroundWorker1.ReportProgress(k);//模拟一个回滚的效果
                    }
                    e.Cancel = true;
                    return;
                }
                manualReset.WaitOne();//如果ManualResetEvent的初始化为终止状态（true），那么该方法将一直工作，直到收到Reset。反之亦然。
                Thread.Sleep(200);
                backgroundWorker1.ReportProgress(i + 1);
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            try
            {
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (btn_Pause.Text == "暂停")
            {
                manualReset.Reset();//暂停当前线程的工作，发信号给WaitOne方法，阻塞
                btn_Pause.Text = "继续";
            }
            else
            {
                manualReset.Set();//继续某个线程的工作
                btn_Pause.Text = "暂停";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lbl_Progress.Text = e.ProgressPercentage.ToString()+"%";
        }
    }
}
