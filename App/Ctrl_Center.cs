using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Ctrl_Center : Form
    {
        private string binpath;
        private string[] local_config;
        private Form1 form1;
        private Sql_Log sql_log;
        public Ctrl_Center(Form1 form1)
        {
            InitializeComponent();
            string runpath = System.AppDomain.CurrentDomain.BaseDirectory;
            string basepath = runpath.Substring(0, runpath.Length - 10);
            this.binpath = basepath + "mybin";
            this.local_config = this.getlocal_config(binpath);
            comboBox1.Items.AddRange(local_config);
            this.form1 = form1;
            textBox2.AppendText("123456");
            comboBox5.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            sql_log = new Sql_Log();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ctrl_Center_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string[] getlocal_config(string binpath)
        {
            //判断配置文件夹是否存在，不存在则创建
            if (!Directory.Exists(binpath))
            {
                Directory.CreateDirectory(binpath);
            }
            //获取配置文件列表
            string[] local_config = Directory.GetFiles(binpath);
            for(int i=0;i<local_config.Length;i++)
            {
                int begin = local_config[i].LastIndexOf('\\');
                local_config[i] = local_config[i].Substring(begin+1);
            }
            return local_config;
        }
        //刷新配置文件列表
        private void flash_local_config_Click(object sender, EventArgs e)
        {
            local_config = getlocal_config(binpath);
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(local_config);
        }

        private void Ctrl_Center_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = binpath + "\\" + comboBox1.Text;
                Console.WriteLine(binpath + "\\" + comboBox1.Text);
                string[] strs1 = File.ReadAllLines(filepath);
                MessageBox.Show(strs1[0]);
            }catch (Exception ex)
            {
                MessageBox.Show("未选择配置文件");
                //记录错误日志
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private SerialPort initser()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    //串口已经处于打开状态
                    serialPort1.Close();    //关闭串口
                    comboBox5.Enabled = true;
                    button5.Text= "打开串口";
                }
                else
                {
                    //串口已经处于关闭状态，则设置好串口属性后打开
                    comboBox5.Enabled = false;
                    serialPort1.PortName = comboBox5.Text;
                    serialPort1.BaudRate = Convert.ToInt32("9600");
                    serialPort1.DataBits = Convert.ToInt16("8");
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    serialPort1.Open();
                    button5.Text= "关闭串口";
                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理
                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                comboBox5.Items.Clear();
                comboBox5.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                MessageBox.Show(ex.Message);
                comboBox5.Enabled = true;
                button5.Text = "关闭串口";
            }
            return serialPort1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.initser();

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //因为要访问UI资源，所以需要使用invoke方式同步ui
                this.Invoke((EventHandler)(delegate
                {
                    textBox2.AppendText(serialPort1.ReadExisting());
                }
                   )
                );

            }
            catch (Exception ex)
            {
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message);

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox3.Text=trackBar1.Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = Convert.ToInt16(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox3.Text = trackBar1.Value.ToString();
            }
            
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            sql_log.write_log(trackBar1.Value.ToString());
            dataGridView1.Rows.Add("qwqeqw","wqeqww");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
