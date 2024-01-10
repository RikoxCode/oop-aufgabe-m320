using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Vehicle : Entity, IOwnable
    {
        public Vehicle(string name) : base(name)
        {

        }

        public void AddToBuilding(Building farm)
        {
            farm.GetOwner().SetVehicle(this);
        }
    }
}
