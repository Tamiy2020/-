using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;


namespace 数据库操作_SQLite_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            //连接数据库
            string dbPath = AppDomain.CurrentDomain.BaseDirectory + @"db\Stu.db";
            string connStr = string.Format("Data Source={0};Pooling=true;FailIfMissing=false;password={1}", dbPath, "");



            //创建连接对象
            SQLiteConnection conn = new SQLiteConnection(connStr);
            if (conn.State == ConnectionState.Closed) conn.Open();

            //SQL语句
            string sqlStr = "select * from students where stu_no like '%" + txt_Select.Text.Trim() + "%'";


            //执行查询语句
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqlStr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "students");

            //方法一
            //dgv_Stu.DataSource = ds;
            //dgv_Stu.DataMember = "students";

            //方法二
            //dgv_Stu.DataSource = ds.Tables["students"];

            //方法三
            DataTable dt = ds.Tables["students"];
            dgv_Stu.DataSource = dt.DefaultView;
        }
    }
}
