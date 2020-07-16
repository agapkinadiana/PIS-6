using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "Task";
        }
        //это клиент
        //маршруты к handker прописаны в webConfig
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create(String.Format("http://localhost:61911/yyy.test?ParmA={0}&ParmB={1}",
                TextBox1.Text, TextBox2.Text)); //создаем запрос
            rq.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)rq.GetResponse();//GetResponse посылаем запрос на сервер GetHandler.cs
            response.Headers.Add("yyy-test", "Septilko Anastasiya"); //заголовок 
            StreamReader sr = new StreamReader(response.GetResponseStream());
            Response.Write(sr.ReadToEnd());
            sr.Close();
        }
    }
}