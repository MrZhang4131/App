using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        private Sql_Log sql;
        private WebClient2Java web;
        private Sign sign_form;
        private SerialPort serialPort;
        
        
        public Form1()
        {
            InitializeComponent();
            this.sql = new Sql_Log();
            this.web = new WebClient2Java();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            bool result=web.login(textBox1.Text,textBox2.Text);
            if (result)
            {
                //显示登录成功界面
                new Ctrl_Center(this).Show();
                this.Hide();
            }
            else
            {
                //保存错误信息
                sql.write_log("log_erro name=" + textBox1.Text + "password=" + textBox2.Text);
                //显示错误界面
                MessageBox.Show("账号或密码错误");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_back_Click(object sender, EventArgs e)
        {
            //显示联系我们
            MessageBox.Show("请联系开发者邮箱:3128385708@qq.com");
        }

        private void sign_Click(object sender, EventArgs e)
        {
            this.sign_form = new Sign(this);
            sign_form.Show();
            this.Hide();
        }
        public void setser(SerialPort ser)
        {
            this.serialPort = ser;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
