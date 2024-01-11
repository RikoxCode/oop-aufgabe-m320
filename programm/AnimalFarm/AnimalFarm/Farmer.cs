using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Farmer : Entity, IOwnable
    {
        public Building Farm { get; set; }

        public Farmer(string name) : base(name) { }

        public void AddToBuilding(Building farm)
        {
            Farm = farm;
            this.Farm.SetOwner(this);
        }

        public void SetVehicle(Vehicle vehicle)
        {
            if(this.Farm != null)
            {
                this.Farm.AddVehicle(vehicle);
            } else
            {
                Console.Write("Farmer does not have any Home! Set first a Building to the Farmer!");
            }
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
            Farm.DisplayInformations();
        }
    }
}
