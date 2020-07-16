using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _18_WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        //особенность в том что мы сопоставляем метод запроса с именем метода , которые определены в web Api контроллере 

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return $" Get - id: {id}";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return "Post";
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return $"Put - id: {id}";
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            
            return $"Delete - id: {id}";
        }
    }
}
