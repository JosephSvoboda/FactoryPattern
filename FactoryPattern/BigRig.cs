using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
        public int Tires { get; set; }

        public void Drive()
        {
            Console.WriteLine("Building a new Big Rig!");
        }
    }
}
