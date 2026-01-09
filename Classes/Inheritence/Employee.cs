using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sensey.Classes.Inheritence
{
    public class Employee
    {
        public int Salary { get; set; }

        public Employee(int salary)
        {
            Salary = salary;
        }
    }
}
