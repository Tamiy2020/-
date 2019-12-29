using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace 一些方法
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            if (isAlreadyRunning())
            {
                MessageBox.Show("软件已打开", "打开提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Application.Run(new Form1());

            }
        }
        private static bool isAlreadyRunning()
        {
            bool b = false;
            Process[] mProcs = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (mProcs.Length > 1)
            {
                b = true;
            }
            return b;
        }
    }
}
