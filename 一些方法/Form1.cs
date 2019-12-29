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

namespace 一些方法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = "Directory.GetCurrentDirectory()" + "    " + Directory.GetCurrentDirectory();
            lbl2.Text = "Application.StartupPath" + "               " + Application.StartupPath;
            lbl3.Text = "AppDomain.CurrentDomain.BaseDirectory" + "    " + AppDomain.CurrentDomain.BaseDirectory;
            lbl4.Text = "Assembly.GetExecutingAssembly().Location" + "   " + Assembly.GetExecutingAssembly().Location;
            Random r = new Random();
            int x = r.Next(100000, 1000000);//不包括maxValue
            lbl5.Text = "生成六位的随机数：" + x.ToString();
        }
    }
}
