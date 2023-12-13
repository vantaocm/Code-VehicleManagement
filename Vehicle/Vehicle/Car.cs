using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car : Vehicle
    {
        public int slots {  get; set; }
        public Car() { }
        public override void input()
        {
            base.input();
            Console.Write("enter slots: ");
            slots = Convert.ToInt32(Console.ReadLine());
        }
        public override void output() {
            
           base.output();
            Console.WriteLine("Slots: " + slots);
        }

    }
}
