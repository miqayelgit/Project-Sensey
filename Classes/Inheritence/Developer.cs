using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sensey.Classes.Inheritence
{
    public class Developer : Employee
    {
        public int Bonus { get; set; }
        public Developer(int salary) : base(salary)
        {
            Bonus = 20;   
        }
    }
}
