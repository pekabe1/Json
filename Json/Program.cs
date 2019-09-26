using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Json
{
    class Program
    {
        Repository repo = new Repository();


        //   var list repo.GetList();
        static void Main(string[] args)
        {
            Repository repo = new repository();

            var data = File.ReadAllText(ConfigurationManager.AppSettings["file"]);
            //JObject jObject = JObject.Parse(data);
            //Console.WriteLine("Name : " + jObject["name"]);






            var personList = JsonConvert.DeserializeObject<List<Person>>(data);
        //    personList.RemoveAt(1);
            string dataToSave = JsonConvert.SerializeObject(personList);
            File.WriteAllText((ConfigurationManager.AppSettings["file"]), dataToSave);


            repo.Add(new Person
            {
                LastName = "Zyhu",
                Name = "Ahdi",
                listOfObjects = new List<string> { "1", "2", "abc" }
            }); ; ;

            string saveNewPerson = JsonConvert.SerializeObject(repo);
            File.WriteAllText(ConfigurationManager.AppSettings["file"], saveNewPerson);


           
            Console.Read();



        }
    }
}


