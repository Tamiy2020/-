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
    }
}
