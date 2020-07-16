using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Lab7_API.Models;

namespace Lab7_API.Controllers
{
    [Route("api/values")]
   
    public class ValuesController : ApiController
    {

        private PersonRepository PersonModel { get; set; } = new PersonRepository();

        // GET api/values
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return PersonModel.GetAll();
        }

        // POST api/values
        [HttpPost]
        public Person PostPersons(Person person)
        {
            return PersonModel.InsertOne(person);
        }

        // PUT api/values
        [HttpPut]
        public Person PutPersons(Person person)
        {
            return PersonModel.UpdateOne(person);
        }
    

        // DELETE api/values/5
        [HttpDelete]
        public void DeletePersons(int id)
        {
            PersonModel.DeleteOne(id);
        }
    }
}
