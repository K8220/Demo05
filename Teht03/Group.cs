using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    /// <summary>
    /// This class holds person objects in a collection.
    /// </summary>
    class Group
    {
        /// <summary>
        /// Collection to store person objects
        /// </summary>
        private List<Student> group;

        /// <summary>
        /// Default constructor initializes a collection
        /// </summary>
        public Group()
        {
            group = new List<Student>();
        }

        /// <summary>
        /// Add person to collection
        /// </summary>
        /// <param name="student">Person to add</param>
        public void AddStudent(Student student)
        {
            group.Add(student);
        }

        /// <summary>
        /// Return a person to caller application
        /// </summary>
        /// <param name="index">index in collection</param>
        /// <returns>person object or null</returns>
        public Student GetStudent(int index)
        {
            if (index < group.Count)
                return group.ElementAt(index);
            else return null;
        }

        public Student FindStudent(string studentID)
        {
            foreach(Student student in group)
            {
                if (studentID.Equals(student.StudentID))
                {
                    return student;
                }
            }
            // no person with that sotu...
            return null;
        }

        public void PrintCollection()
        {
            foreach(Student student in group)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
