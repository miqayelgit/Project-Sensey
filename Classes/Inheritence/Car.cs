using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project_Sensey.Interfaces;

namespace Project_Sensey.Classes.Inheritence
{
    public class Car
    {
        public string Make{ get; set; }
        public int Milage { get; set; }

        public Car(string make)
        {
            Make = make;
        }


    }

    public class BMW : Car, IGoable
    {
        public int MaxSpeed{ get; set; }
        public BMW(string make, int maxSpeed) : base(make)
        { 
            MaxSpeed = maxSpeed;
        }


        public void GoToLeft()
        {
            Console.WriteLine("Goes left");
        }

        public void GoToRight()
        {
            Console.WriteLine("Goes right"); ;
        }

        public void GoBack()
        {
            Console.WriteLine("Goes back");
        }

        public void GoFast()
        {
            Console.WriteLine("Goes Fast"); ;
        }

        public void Slow()
        {
            Console.WriteLine("Goes slow");
        }

        public void MakesNois()
        {
            Console.WriteLine("Noisyy");
        }
    }
}
