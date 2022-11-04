using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(double vehicleType)
        {
            switch (vehicleType)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                case 6:
                    return new Dually();
                case 18:
                    return new BigRig();
                default:
                    return new Motorcycle();
            }
        }
    }
}
