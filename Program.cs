

using Project_Sensey.Classes;

class Program
{
    public static void Main()
    {

        Student[] students = StudentService.CreateStudentsArray(5);
        Console.WriteLine("Printing Students...");
        StudentService.PrintStudents(students);

        Console.WriteLine("------------------------------------");

        Student[] olderStudents = StudentService.GetOlderStudentsArray(students, 16);
        Console.WriteLine("Printing Older Students...");
        StudentService.PrintStudents(olderStudents);
        Console.WriteLine("-----------------------------------");
        if (olderStudents.Length > 0)
        {
            Console.WriteLine($"Changed {olderStudents[0].FirstName} {olderStudents[0].LastName} to Smbo.");
            olderStudents[0].FirstName = "Smbo";
        }

        Console.WriteLine("Printing students again");
        StudentService.PrintStudents(students);





    }
}