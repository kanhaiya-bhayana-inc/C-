using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* In this Example You have the source code the user-defined type Student and if you want to sort your data on the column field then you need to define the logic for IComparable
    and write logic for the IComparable

    but in case you do not have the source code so then how will you sort the list,
    suppose I want to sort the list based on the marks of the students,
    so in this case you will create an another class which will implement the IComparer interface and inside that you will define
    your logic...

    See below exaplme for the reference...
*/

namespace CollectionsImplementation
{
    class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public double Marks { get; set; }

        public int CompareTo(Student? other)
        {
            if (this.Id > other.Id) return 1;
            else if (this.Id < other.Id) return -1; else return 0;
        }
    }

    class CompareStudents : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x.Marks > y.Marks) return 1;
            else if (x.Marks < y.Marks) return -1; else return 0;
        }
    }
    internal class Exaple_IComparable_IComparer
    {
        public static int CompareNames(Student S1, Student S2)
        {
            return S1.Name.CompareTo(S2.Name);
        }
        static void Main()
        {

            Student c1 = new Student { Id = 1, Name = "Arik", City = "Hyderabad", Phone = "+91-1234567890", Marks = 89.56 };
            Student c2 = new Student { Id = 2, Name = "Smith", City = "Chennai", Phone = "+91-1234567890", Marks = 79.56 };
            Student c3 = new Student { Id = 3, Name = "Dave", City = "Pune", Phone = "+91-1234567890", Marks = 99.56 };
            Student c4 = new Student { Id = 4, Name = "Williams", City = "Delhi", Phone = "+91-1234567890", Marks = 59.56 };

            List<Student> list = new List<Student>() { c1, c4, c3, c2 };
            /*CompareStudents obj = new CompareStudents();*/

            /* for retreiving the list based on the Student Marks you need to create the object of the class which is implementing
                 the IComparer and pass that object as a parameter inside the Sort() method....
            */

            // Approach - 1 - Creating the object of Delegate and pass the object.. 
            /*Comparison<Student> obj = new Comparison<Student>(CompareNames);*/
            /*list.Sort(obj);*/

            // Approach - 2 - Directly pass the function name but signaturer must be match with the delegate 
            /*list.Sort(CompareNames);*/

            // Approach - 3 - Anonymous Function - Create Anonymous function using keyword delegate
            /*list.Sort(delegate (Student s1, Student s2)
            {
                return s1.Name.CompareTo(s2.Name);
            });*/

            // Approach - 4 - Using Lambda Function
            /*list.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));*/


            foreach (Student c in list)
            {
                Console.WriteLine(c.Id + ", " + c.Name + ", " + c.City + ", " + c.Phone + " : " + c.Marks);
            }
        }
    }
}
