using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Machine_config
    {
        private Joint[] joint;
        private SerialPort serial;
        private String erroinfo;
        private Sql_Log sql { set; get; }
        //初始化机械配置，初始化关节
        public Machine_config(int[] arr,SerialPort serial,Sql_Log sql) {
            joint[0]= new Joint(arr[0]);
            joint[1]= new Joint(arr[1]);
            joint[2]= new Joint(arr[2]);
            joint[3]= new Joint(arr[3]);
            this.serial = serial;
            erroinfo = "";
            this.sql = sql;
        }
        //单关节调试
        public void set_joint(int index,int value)
        {
            joint[index].Write_joint(serial, value,out erroinfo);
            having_erro();

        }
        public void having_erro()
        {
            if (!erroinfo.Equals("")){
                //写入SQL错误日志
                sql.write_log(erroinfo);

                //弹出弹窗

                //命令行输出错误原因
                Console.WriteLine(erroinfo);
                //错误信息复位
                this.erroinfo = "";
            }
        }

    }
}
