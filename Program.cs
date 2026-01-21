

using Project_Sensey.Classes;
using Project_Sensey.Classes.Inheritence;
using Project_Sensey.Generics;
using Project_Sensey.Struct;

class Program
{
    public static void Main()
    {
        Random random = new Random();
        MyList<string> list = new MyList<string>();
     
        for (int i = 0; i < 6; i ++)
        {
            int a = random.Next(5, 15);
            list.Add("Mikayel: " + a);
        }    

        while(list.HasNext())
        {
            list.PrintCurrent();
        }

        while (list.HasNext())
        {
            list.PrintCurrent();
        }


    }
}