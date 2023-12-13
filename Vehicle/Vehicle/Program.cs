using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selection;
            VehicleManagement manage = new VehicleManagement();
            do
            {
                selection = manage.Menu();
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("enter Vehicle Type");
                        Console.WriteLine("enter Car");
                        Console.WriteLine("enter Bike");
                        string vehicleTyppe = Console.ReadLine();
                        manage.addvehicle(vehicleTyppe);
                        break;
                    case 2:
                        Console.WriteLine("------------------");
                        manage.showvehicles();
                        break;
                    case 3:
                        Console.WriteLine("------------------");
                        manage.removevehicle();
                        break;
                    case 4:
                        Console.WriteLine("------------------");
                        manage.RegisterCustomer();
                        break;
                    case 5:
                        Console.WriteLine("------------------");
                        manage.login();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } 
            while (selection != 6);
        }
    }
}
