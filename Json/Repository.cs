using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Configuration;
using Newtonsoft.Json;

namespace Json
{
    public class Repository
    {
        //readonly string path = File.ReadAllText(ConfigurationManager.AppSettings["file"]);
        List<Person> personList = JsonConvert.DeserializeObject<List<Person>>("Data.json") ;

        public void Add(Person person)
        {


            personList.Add(new Person
            {
                LastName = person.LastName,
                Name = person.Name,
                listOfObjects = person.listOfObjects
            });
        }

        internal List<Person> GetPerson()
        {
            return personList;


        }
    }
}
