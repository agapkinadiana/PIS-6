using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Web;

namespace _14_MVC_CONTROLLER_MODEL.Models
{
    public class PersonRepository
    {
        private const string PERSON_JSON_PATH = @"/Users/dianaagapkina/Desktop/ASP.NET/14_MVC_CONTROLLER_MODEL/14_MVC_CONTROLLER_MODEL/Models/persons.json";

        public List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();

            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<Person>));

            using (var jsonStream = new StreamReader(PERSON_JSON_PATH))
            {
                persons.AddRange((List<Person>)deserializer.ReadObject(jsonStream.BaseStream));
            }

            return persons;
        }

        public Person InsertOne(Person person)
        {
            List<Person> persons = GetAll();
            person.Id = persons.Count;
            persons.Add(person);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>));

            using (var jsonStream = new StreamWriter(PERSON_JSON_PATH))
            {
                serializer.WriteObject(jsonStream.BaseStream, persons);
            }
            return person;
        }
    }
}