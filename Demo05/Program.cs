using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            // new person objects
            Person person1 = new Person
            {
                Firstname = "Kirsi",
                Lastname = "Mainio",
                SocialSecurityNumber = "112212-1212"
            };

            Person person2 = new Person
            {
                Firstname = "Salla",
                Lastname = "Aalto",
                SocialSecurityNumber = "113313-1313"
            };

            Person person3 = new Person
            {
                Firstname = "Timo",
                Lastname = "Laine",
                SocialSecurityNumber = "114414-1414"
            };

            Person person4 = new Person
            {
                Firstname = "Kalle",
                Lastname = "Kovis",
                SocialSecurityNumber = "115515-1515"
            };

            // create a Persons object
            Persons myFriends = new Persons();

            // add person objects to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);
            myFriends.AddPerson(person4);

            // get one person from Persons collection
            Person person5 = myFriends.GetPerson(5);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            } else
            {
                Console.WriteLine("Person not found in that index!");
            }

            // print collection
            myFriends.PrintCollection();

            // find person
            string sotu = "114414-1416";
            Console.WriteLine("Find sotu : " + sotu);
            Person person6 = myFriends.FindPerson(sotu);
            if (person6 != null)
            {
                Console.WriteLine(person6.ToString());
            } else
            {
                Console.WriteLine("Can't find person with that sotu...");
            }
        }
    }
}
