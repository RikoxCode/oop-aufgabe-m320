using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Animal : Entity
    {
        public Animal(string name) : base(name) { }

        public void DisplayInfo()
        {
            Console.WriteLine($"        - {Name}");
        }
    }
}
