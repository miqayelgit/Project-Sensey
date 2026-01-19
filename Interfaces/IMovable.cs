using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sensey.Interfaces
{
    public interface IMovable
    {
        void GoToLeft();
        void GoToRight();
        void GoBack();
    }

    public interface IGoable : IMovable
    {
        void GoFast();
        void Slow();

        void MakesNois() => Console.WriteLine("Makes noise");
    }
}
