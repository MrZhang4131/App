using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal interface Mashine_Interface
    {
        void Read_joint(SerialPort serial,out String erroinfo);
        void Write_joint(SerialPort serial,int number,out String erroinfo);
    }
}
