using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using _10_ASMX.Models;

namespace _10_ASMX.Services
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private PersonRepository Repository { get; set; }

        public WebService1()
        {
            Repository = new PersonRepository();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        [WebMethod]
        public List<Person> GetDict()
        {
            return Repository.GetAll().ToList();
        }

        [WebMethod]
        public Person AddDict(Person person)
        {
            return Repository.InsertOne(person);
        }
    }
}
