using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sensey.Classes
{
    public class StudentService
    {
        static Random random = new Random();
        public static Student[] CreateStudentsArray(int count)
        {
            Student[] students = new Student[count];
            for (int i = 0; i < count; i++)
            {
                Student student = new Student(
                    id: i + 1,
                    firstName: StudentsData.FirstNames[random.Next(0, StudentsData.FirstNames.Length)],
                    lastName: StudentsData.LastNames[random.Next(0, StudentsData.LastNames.Length)],
                    age: random.Next(16, 31));

                students[i] = student;
            }

            return students;
        }

        public static Student[] GetOlderStudentsArray(Student[] students, int age)
        {
            int olderStudentsCount = GetOlderStudentsCount(students, age);
            int count = 0;
            Student[] olderStudents = new Student[olderStudentsCount];

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Age > age)
                {
                    Student student = new Student(students[i]);
                    olderStudents[count] = student;
                    count++;
                }

            }
            return olderStudents;

        }

        public static void PrintStudents(Student[] students)
        {
            for (int i = 0;i < students.Length;i++)
            {
                Console.WriteLine(students[i]);
            }
        }
        private static int GetOlderStudentsCount(Student[] students, int age)
        {
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Age > age)
                    count++;
            }
            return count;
        }
    }
}
