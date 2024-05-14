using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Joint : Mashine_Interface
    {
        private int value { get; set; }
        public Joint(int value) { 
            this.value = value;
        }

        public void Read_joint(SerialPort serial,out String erroinfo)
        {
            try
            {
                serial.Open();
                this.value = Convert.ToInt16(serial.ReadLine());
                erroinfo = "";
                serial.Close();
            }
            catch (Exception ex) {
                erroinfo = "串口打开失败";
            }
        }

        public void Write_joint(SerialPort serial, int number,out String erroinfo)
        {
            try {
                serial.Open();
                String str=number.ToString();
                serial.Write(str);
                serial.Close();
                erroinfo = "";
            }
            catch (Exception ex)
            {
                erroinfo = "串口打开失败";
            }
        }
    }
}
