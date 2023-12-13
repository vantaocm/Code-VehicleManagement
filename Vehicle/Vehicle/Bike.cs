using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Bike : Vehicle
    {
        public string size {  get; set; }
        public Bike() { 
        
        }
        public override void input()
        {
            base.input();
            Console.Write("enter size");
            size = Console.ReadLine();
        }
        public override void output()
        {
            base.output();
            Console.Write("Size: " + size);
        }
    }
}
