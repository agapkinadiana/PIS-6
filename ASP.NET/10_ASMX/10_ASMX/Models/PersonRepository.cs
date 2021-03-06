﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Web;


namespace _10_ASMX.Models
{
    public class PersonRepository
    {
        private const string PERSON_JSON_PATH = @"D:\Учёба\3 curs\2 сем\asp.NET\exzam\10_ASMX\10_ASMX\Models\persons.json";

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