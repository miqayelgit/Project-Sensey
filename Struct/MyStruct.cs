using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Sensey.Classes.Inheritence;

namespace Project_Sensey.Struct
{
    internal struct MyStruct
    {
        public int Id { get; set; }
        public Car car { get; set; }

        public MyStruct(int id, Car car)
        {
            Id = id;
            this.car = car;
        }
    }

}
