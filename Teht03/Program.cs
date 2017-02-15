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
            Student student1 = new Student { Firstname = "Esa", Lastname = "Lehtinen", SocialSecurityNumber = "112212-1212", StudentID = "K8220" };
            Student student2 = new Student { Firstname = "Late", Lastname = "Girsén", SocialSecurityNumber = "332211-1515", StudentID = "K7291" };
            Student student3 = new Student { Firstname = "Tanheli", Lastname = "Sormustin", SocialSecurityNumber = "151515-1122", StudentID = "K9234" };
            
            // create a Persons object
            Group students = new Group();

            // add person objects to persons collection
            students.AddStudent(student1);
            students.AddStudent(student2);
            students.AddStudent(student3);

            // get one person from Persons collection
            Student student5 = students.GetStudent(5);
            if (student5 != null)
            {
                Console.WriteLine(student5.ToString());
            }
            else
            {
                Console.WriteLine("Person not found in that index!");
            }

            // print collection
            students.PrintCollection();

            // find person
            string sID = "K7291";
            Console.WriteLine("Find student : " + sID);
            Student student6 = students.FindStudent(sID);
            if (student3 != null)
            {
                Console.WriteLine(student6.ToString());
            }
            else
            {
                Console.WriteLine("Can't find person with that sotu...");
            }
        }
    }
}
