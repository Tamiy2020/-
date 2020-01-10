using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace 连接数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接数据库

            //声明一个连接的对象
            //方法一
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = "127.0.0.1"; //服务器名称
            scsb.UserID = "sa";//登录名
            scsb.Password = "e7lovetm";//密码
            scsb.InitialCatalog = "stu_db";//数据库

            //方法二
            //string connStr = "Data Source=127.0.0.1;Initial Catalog=stu_db;User ID=sa;Password=e7lovetm";

            //创建连接
            SqlConnection conn = new SqlConnection(scsb.ToString());
            //SqlConnection conn = new SqlConnection(connStr);

            while (true)
            {
                Console.WriteLine("请输入学号：");
                //打开连接
                if (conn.State == ConnectionState.Closed)//判断是否有连接
                    conn.Open();
                string stu_no = Console.ReadLine();
                //创建要执行的SQL语句
                //字符串拼接 string +
                string sqlStr = "select * from students where stu_no ='" + stu_no + "'"; //查询

                //创建用于执行SQL语句的对象
                SqlCommand comm = new SqlCommand(sqlStr, conn);//参数1：SQL语句字符串 参数2：已经打开的连接

                SqlDataReader sdr;
                try
                {
                    //执行comm对象
                    //接受查询到的SQL结果
                    sdr = comm.ExecuteReader();
                    //读取数据
                    while (sdr.Read())
                    {
                        Console.WriteLine("姓名：" + sdr["stu_nm"].ToString());
                        Console.WriteLine("---------------------------------");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally  //无论是否抛异常都会执行此语句
                {
                    conn.Close();
                }
            }
        }
    }
}
