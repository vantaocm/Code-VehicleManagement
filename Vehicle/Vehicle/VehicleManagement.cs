using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class VehicleManagement
    {
        public List<Vehicle> listvehicles { get; set; }
        public List<Customer> listcustomers { get; set; }
        public VehicleManagement() { 
            listvehicles= new List<Vehicle>();
            listcustomers= new List<Customer>();
        }
        public void addvehicle(string vehicleType) {
            Vehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
            vehicle.input();
            listvehicles.Add(vehicle);
            Console.WriteLine("add vehicle successfully");
        }
        public void showvehicles() {
            if (listvehicles.Count > 0) {
                listvehicles.ForEach(v => v.output());
            }
            else {
                Console.Write("\nDont' have any vehicle");

            }
        }
        public void removevehicle()
        {
            if (listvehicles.Count > 0)
            {
                listvehicles.ForEach(v => v.output());
            }
            else
            {
                Console.Write("\nDont' have any vehicle");

            }
            Console.WriteLine("========== Remove Vehicle ==========");
            string vehicleID = Console.ReadLine();
            bool Removed = listvehicles.RemoveAll(v => v.VehicleID == vehicleID) > 0;
            if (Removed)
            {
                Console.WriteLine("Vehicle removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid vehicle ID. Please try again.");
            }
        }
        public void RegisterCustomer()
        {
            Console.WriteLine("========== Register Customer ==========");
            Console.Write("Customer Name: ");
            string customerName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Customer customer = new Customer(customerName, password);
            listcustomers.Add(customer);
            Console.WriteLine("Customer registered successfully.");
        }
        
        public void login() {
            VehicleManagement manage = new VehicleManagement();
            Console.WriteLine("========== Customer Login ==========");
            Console.Write("Customer Name: ");
            string customerName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Customer customer = listcustomers.FirstOrDefault(e => e.Name == customerName && e.Password == password);
                if (customer != null)
                {
                bool logout = false;
                Console.WriteLine($"Welcome, {customer.Name}!");
                    while (!logout)
                    {
                        Console.WriteLine("1. Buy Vehicle");
                        Console.WriteLine("2. Logout");
                        Console.Write("Please enter your choice: ");
                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                customer.BuyVehicle(listvehicles);
                                break;
                            case "2":
                                logout = true;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    Console.WriteLine();
                    }
                }
                else
                {
                Console.WriteLine("Your Id or Password is invalid. Please enter again!");
                }
            }

        public int Menu() {
            int selection = 0;
            Console.WriteLine("\n========== Vehicle Management System ==========");
            Console.WriteLine("1. Add Vehicle\n2. Show Vehicles"
                         + "\n3. Remove vehicle\n4. Register account for customer"+"\n5. Customer Login\n6.Exit");
            Console.WriteLine("Enter selection: ");
            selection = Convert.ToInt32((string)Console.ReadLine());
            return selection;
        }
    }
}
