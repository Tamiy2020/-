using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace 一些方法
{
    public partial class Form1 : Form
    {
        private readonly Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = "Directory.GetCurrentDirectory()" + "    " + Directory.GetCurrentDirectory();
            lbl2.Text = "Application.StartupPath" + "               " + Application.StartupPath;
            lbl3.Text = "AppDomain.CurrentDomain.BaseDirectory" + "    " + AppDomain.CurrentDomain.BaseDirectory;
            lbl4.Text = "Assembly.GetExecutingAssembly().Location" + "   " + Assembly.GetExecutingAssembly().Location;
            lbl5.Text = "生成六位的随机数：" + r.Next(100000, 1000000).ToString();
        }

        /// <summary>
        /// 点击【生成随机数】按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Random_Click(object sender, EventArgs e)
        {
            lbl5.Text = "生成六位的随机数：" + r.Next(100000, 1000000).ToString();//不包括maxValue
        }

        /// <summary>
        /// 最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                pic_Max.Image = Image.FromFile("最大化.png");
                return;
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                pic_Max.Image = Image.FromFile("最大化 (1).png");
                this.WindowState = FormWindowState.Normal;
                return;
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();   //只是关闭当前窗口，若不是主窗体的话，是无法退出程序的，另外若有托管线程（非主线程），也无法干净退出；
            Application.Exit();  //强制所有消息中止，退出所有的窗体,但是若有托管线程（非主线程），也无法干净地退出；  
            Application.ExitThread(); //强制中止调用线程上的所有消息，同样面临其它线程无法正确退出的问题；  
            Environment.Exit(0);   //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净，退出时有可能会抛出异常;

            #region 程序退出
            Process tt = Process.GetProcessById(Process.GetCurrentProcess().Id);
            tt.Kill();//直接杀死与本程序相关的所有进程，有可能会导致数据丢失，但是不会抛出异常。 
            #endregion
        }

        #region 关闭样式
        private void pic_Close_MouseEnter(object sender, EventArgs e)
        {
            pic_Close.BackColor = Color.Red;
        }

        private void pic_Close_MouseLeave(object sender, EventArgs e)
        {
            pic_Close.BackColor = default;
        }

        private void pic_Close_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Close.BackColor = Color.Crimson;
        }
        #endregion
    }
}
