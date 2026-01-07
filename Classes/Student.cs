using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project_Sensey.Classes
{
    public class Student
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int Age;

        public Student(int id, string firstName, string lastName, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Student(Student student) 
        {
            Id = student.Id;
            FirstName = student.FirstName;
            LastName= student.LastName;
            Age = student.Age;
        }

        public override string ToString()
        {
            return $"Id : {this.Id} \nFirst Name : {this.FirstName} \n" +
                $"Last Name: {this.LastName} \nAge :  {this.Age} \n";

        }
    }
}
