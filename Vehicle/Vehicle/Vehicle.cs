using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vehicle
{
    internal abstract class Vehicle
    {
        public string VehicleID { get; set; }
        public string VehicleName { get; set; }
        public string Brand { get; set; }
        public Decimal Price { get; set; }
        public int YearOfManufacture { get; set; }
        public virtual void input()
        {
            Console.WriteLine("Enter Vehicle Id: ");
            VehicleID = Console.ReadLine();
            Console.WriteLine("Enter Vehicle Name: ");
            VehicleName = Console.ReadLine();
            Console.WriteLine("Enter Brand: ");
            Brand = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            Price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Year Of Manufacture: ");
            YearOfManufacture = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void output()
        {
            Console.WriteLine("==========");
            Console.WriteLine("Vehicle Id:" + VehicleID);
            Console.WriteLine("Vehicle Name:" + VehicleName);
            Console.WriteLine("Vehicle Brand:" + Brand);
            Console.WriteLine("Vehicle Price:" + Price);
            Console.WriteLine("Vehicle Year Of Manufacture:" + YearOfManufacture);       
        }

    }
}
