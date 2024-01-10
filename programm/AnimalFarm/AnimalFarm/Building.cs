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

        private List<Vehicle> vehicles;

        private Farmer Farmer;

        public Building()
        {
            Animals = new List<Animal>();
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public Farmer GetOwner()
        {
            return this.Farmer;
        }

        public void SetOwner(Farmer farmer)
        {
            this.Farmer = farmer;
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
        }

        private void DisplayAnimals()
        {
            Console.WriteLine($"    In diesem Gebäude gibt es {Animals.Count} Tiere:");
            foreach (var animal in Animals)
            {
                animal.DisplayInfo();
            }
        }

        private void DisplayVehicles()
        {
            Console.WriteLine($"    In diesem Gebäude gibt es {this.vehicles.Count} Fahrzeuge");
        }

        public void DisplayInformations()
        {
            Console.WriteLine($"Das ist das Gebäude von {this.Farmer.Name}");
            this.DisplayVehicles();
            this.DisplayAnimals();
        }
    }
}
