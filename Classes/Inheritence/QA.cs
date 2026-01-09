using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sensey.Classes.Inheritence
{
    public class QA : Employee
    {
        public int Bonus { get; set; }

        public QA(int salary) : base(salary)
        {
            Bonus = 15;
        }
    }
}
