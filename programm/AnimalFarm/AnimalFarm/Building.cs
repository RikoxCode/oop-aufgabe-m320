using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Building
    {
        public List<Animal> Animals { get; set; }

        public Building()
        {
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
        }

        public void DisplayAnimals()
        {
            Console.WriteLine($"   In diesem Gebäude gibt es {Animals.Count} Tiere:");
            foreach (var animal in Animals)
            {
                animal.DisplayInfo();
            }
        }
    }
}
