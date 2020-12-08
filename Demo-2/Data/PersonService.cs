using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class PersonService
    {
        readonly static List<Person> Persons = null;
         static  PersonService()
        {
            Persons= new List<Person>
          {
            new Person { Id = 1, Name = "xyz", Address = "15,east Dr, CA" },
            new Person { Id = 2, Name = "xyz2", Address = "16,east Dr, IL" },
            new Person { Id = 3, Name = "xyz3", Address = "16,east Dr, CA" },
            new Person { Id = 4, Name = "xyz4", Address = "17,east Dr, NY" },
            new Person { Id = 5, Name = "xyz5", Address = "18,east Dr, FL" },
            new Person { Id = 6, Name = "xyz6", Address = "19,east Dr, TX" }
          };
        }
        public static Person GetPerson(int id )
        { if (id > 0)
                return Persons.FirstOrDefault(x => x.Id == id);
            else return new Person();
        }

        public static List<Person>  GetPersons()
        {
            return Persons;
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
