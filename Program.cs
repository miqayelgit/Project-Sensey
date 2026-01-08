

using Project_Sensey.Classes;

class Program
{
    public static void Main()
    {

        //Student[] students = StudentService.CreateStudentsArray(29);
        //Console.WriteLine("Printing Students...");
        //StudentService.PrintStudents(students);

        //Console.WriteLine("------------------------------------");

        //Student[] olderStudents = StudentService.GetOlderStudentsArray(students, 21);
        //Console.WriteLine("Printing Older Students...");
        //StudentService.PrintStudents(olderStudents);
        //Console.WriteLine("-----------------------------------");
        //if (olderStudents.Length > 0)
        //{
        //    Console.WriteLine($"Changed {olderStudents[0].FirstName} {olderStudents[0].LastName} to Smbo.");
        //    olderStudents[0].FirstName = "Smbo";
        //}

        //Console.WriteLine("Printing students again");
        //StudentService.PrintStudents(students);

        int[,] matrix = MatrixService.CreateMatrix(6, 6);
        Console.WriteLine("Matrix!");
        MatrixService.PrintMatrix(matrix);
        Console.WriteLine();
        Console.WriteLine("Sum Of Main Diagonal: " + MatrixService.SumMainDiagonal(matrix));



    }
}