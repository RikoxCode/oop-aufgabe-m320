using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Farmer : Entity, IOwnable
    {
        public Building Farm { get; set; }

        public Farmer(string name) : base(name) { }

        public void OwnFarm(Building farm)
        {
            Farm = farm;
        }

        public void AddAnimalToFarm(Animal animal)
        {
            Farm.AddAnimal(animal);
        }

        public void RemoveAnimalFromFarm(Animal animal)
        {
            Farm.RemoveAnimal(animal);
        }

        public void DisplayFarmInfo()
        {
            Console.WriteLine($"\n Bauer {Name} besitzt eine Farm mit folgenden Tieren:");
            Farm.DisplayAnimals();
        }
    }
}
