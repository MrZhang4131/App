using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    internal class Sql_Log
    {
        private SqlConnection sqlConnection;
        //默认数据库连接
        public Sql_Log() {
            
            string sqlstr = "Data Source=localhost;Initial Catalog=master;User ID=sa;Pwd=123456";
            SqlConnection con = new SqlConnection(sqlstr);//创建一个MySqlConnection对象
            try
            {
                con.Open();
                con.Close();
                sqlConnection = con;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //弹出错误视窗

            }
        }
        //部署测试用例
        public Sql_Log(String Data_Source,String Initial_Catalog,String User_ID,String Pwd)
        {
            String sqlstr = "Data Source=" + Data_Source + ";Initial Catalog=" + Initial_Catalog + ";User ID=" + User_ID + ";Pwd=" + Pwd;
            SqlConnection con = new SqlConnection(sqlstr);//创建一个MySqlConnection对象
            try
            {
                con.Open();
                con.Close();
                sqlConnection =con;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //弹出错误视窗

            }
        }
        //写入本机日志
        public void write_log(string log)
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                //弹出错误视窗
                MessageBox.Show(ex.Message);

            }
            DateTime dateTime = DateTime.Now;
            String stringtime2 = dateTime.ToString("yyyy-MM-dd");
            string sql = String.Format("insert into App_log (Datatime,erro)values("+stringtime2+",\'"+log+"\')");
            //生成sql指令
            SqlCommand cmd = new SqlCommand(sql,sqlConnection);
            //执行
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("指令执行成功");
            }
            catch (SqlException e)
            {
                MessageBox.Show("指令执行失败");
                MessageBox.Show(e.Message);
            }
            finally
            {
               sqlConnection.Close();//对数据库操作完成后，需要关闭数据库，释放内存
            }
        }
    }
}
