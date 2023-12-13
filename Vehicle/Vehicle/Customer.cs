using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Password {  get; set; }
        public Customer(string Name, string Password) { 
            this.Name = Name;
            this.Password = Password;
        }
        public void Input() {
            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter password");
            Password = Console.ReadLine();
        }
        public void BuyVehicle(List<Vehicle> listvehicles)
        {
            Console.WriteLine("========== Buy Vehicle ==========");
            Console.WriteLine("Available Vehicles:");
            if (listvehicles.Count > 0)
            {
                listvehicles.ForEach(v => v.output());
                Console.Write("Enter the ID of the vehicle you want to buy: ");
                string vehicleID = Console.ReadLine();
                Vehicle selectedVehicle = listvehicles.FirstOrDefault(v => v.VehicleID == vehicleID);

                if (selectedVehicle != null)
                {
                    Console.WriteLine("Vehicle purchased successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid vehicle ID. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("\nDont have any vehicles");
            }

        }
    }
}
