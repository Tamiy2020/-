using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;//引用正则表达式命名空间

namespace 正则表达式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 点击btn_OK按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string str = txt_Regex.Text;
            if (str=="190610")
            {
                MessageBox.Show("密码输入正确");
                btn_OK.Focus();
                return;
            }
            else
            {
                MessageBox.Show("密码输入错误");
                txt_Regex.Clear();
                txt_Regex.Focus();
            }
           
        }


        /// <summary>
        /// txt_Regex输入提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Regex_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Regex.Text, "^[0-9]{0,6}$"))//纯数字
            {
               
                lbl_Tips.Text = "请输入纯数字密码";
                return;
            }
            lbl_Tips.Text = "";
        }

        /// <summary>
        /// 按下ENTER 键触发btn_OK事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e.KeyValue =13"></param>
        private void txt_Regex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue ==13)//ENTER 键
            {
                btn_OK.PerformClick();//触发btn_OK事件
            }
        }
    }
}
