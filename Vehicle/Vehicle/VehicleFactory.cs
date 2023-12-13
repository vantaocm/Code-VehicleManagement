using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class VehicleFactory
    {
        public enum vehicleType { 
        Car,
        Bike,
        Truck,
        }
        public static Vehicle GetVehicle(string vehicleType) { 
         Vehicle vehicle = null;
            switch (vehicleType)
            {
                case "Car":
                    vehicle = new Car();
                    break;
                case "Bike":
                    vehicle = new Bike();
                    break;
                default:  vehicle = new Car();
                    break;
            }
            return vehicle;
        }
    }
}
