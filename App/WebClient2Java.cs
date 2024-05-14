using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class WebClient2Java
    {
        //JAVA服务器的IP地址和端口号
        private String Ip_adress;
        //忘了写来干嘛的暂时
        public Dictionary<String, String> config;
        //数据库对象指针，调用本地数据库写入异常日志
        private SqlConnection sql{set; get;}
        
        public WebClient2Java() {
            Ip_adress = "http://localhost:8080/";
        }
        public void set_config()
        {

        }
        //访问特定的URL获取回传
        public String get_response(String path)
        {
            WebRequest webRequest = WebRequest.Create(Ip_adress+path);
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            String str = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return str;
        }
        //用于访问远程服务器登录
        public bool login(String username, String password) {
            String connet_str = Ip_adress + "login?username=" + username + "&password=" + password;
            WebRequest request = WebRequest.Create(connet_str);
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            String str = reader.ReadToEnd();
            bool key = Convert.ToBoolean(str);
            return key;
        }
        //上传云端本地配置文件
        public void upload_config()
        {

        }


    }
}
