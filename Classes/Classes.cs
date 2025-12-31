using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project_Sensey.Classes
{
    internal class Student
    {
        string[] FirstNames = { "John", "James", "Artur", "Edward", "Paruyr", "Avetiq" };
        string[] LastNames = { "Smith", "Snow", "Last", "Norton", "Sevak", "Isahakyan" };
        int Id;
        string FirstName;
        string LastName;
        int Age;

        public Student(int id)
        {
            Random random = new Random();

            Id = id;
            FirstName = FirstNames[random.Next(0, FirstNames.Length)];
            LastName = LastNames[random.Next(0, LastNames.Length)];

            while (Age < 16)
            {
                Age = random.Next(0, 30);
            }
        }

        public override string ToString()
        {
            return $"Id : {this.Id} \nFirst Name : {this.FirstName} \n" +
                $"Last Name: {this.LastName} \nAge :  {this.Age} \n";

        }


        public static void Main()
        {
            var studentsLists = Implement(5);
        }

        public static Student[][] Implement(int studentsCount)
        { 
            Student[] StudentsList = [];
            Student[] OlderStudentsList = [];

            int StudentId = 1;
            int StudentsIndex = 0;
            int OlderStudentsIndex = 0;

            while (studentsCount > 0)
            {
                Student student = new Student(StudentId);
                if (student.Age > 20)
                {
                    Student[] TempArray = new Student[StudentsList.Length + 1];
                    TempArray = CopyArray(StudentsList, TempArray);
                    TempArray[StudentsIndex] = student;
                    StudentsList = TempArray;
                    StudentsIndex++;

                }
                else
                {
                    Student[] TempArray = new Student[OlderStudentsList.Length + 1];
                    TempArray = CopyArray(OlderStudentsList, TempArray);
                    TempArray[OlderStudentsIndex] = student;
                    OlderStudentsList = TempArray;
                    OlderStudentsIndex++;

                }

                StudentId++;
                studentsCount--;
            }

            return [StudentsList, OlderStudentsList];
        }

        public static Student[] CopyArray(Student[] InitialArray, Student[] TargetArray)
        {
            for (int i = 0; i < InitialArray.Length; i++)
            {
                TargetArray[i] = InitialArray[i];
            }

            return TargetArray;
        }
    }
}
