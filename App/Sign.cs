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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace App
{
    public partial class Sign : Form
    {
        private SerialPort ser;
        private Form1 form1;
        public Sign(Form1 form1)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            this.form1 = form1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sign_button_Click(object sender, EventArgs e)
        {
            //发送Http请求返回bool结果
            bool result=true;
            if (result)
            {
                MessageBox.Show("注册成功");
                form1.Show();
                if (ser != null)
                {
                    ser.Close();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("账号已存在");
            }

        }
        private SerialPort initser()
        {
            try {
                if (serialPort1.IsOpen)
                {
                    //串口已经处于打开状态
                    serialPort1.Close();    //关闭串口
                    comboBox1.Enabled = true;
                }
                else
                {
                    //串口已经处于关闭状态，则设置好串口属性后打开
                    comboBox1.Enabled = false;
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32("9600");
                    serialPort1.DataBits = Convert.ToInt16("8");
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理
                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                MessageBox.Show(ex.Message);
                comboBox1.Enabled = true;
            }
            return serialPort1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.ser=this.initser();
            textBox3.Text = "1111-2222-3333-4444";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_Load(object sender, EventArgs e)
        {

        }

        private void Sign_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
