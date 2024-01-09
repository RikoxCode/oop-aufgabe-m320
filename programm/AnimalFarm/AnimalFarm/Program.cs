using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erstellen von Tieren
            Animal cow1 = new Animal("Kuh1");
            Animal cow2 = new Animal("Kuh2");
            // ... (weitere Tiere)

            // Erstellen von Gebäuden (Farmen)
            Building farm1 = new Building();
            Building farm2 = new Building();

            // Tiere zu den Farmen hinzufügen
            farm1.AddAnimal(cow1);
            farm1.AddAnimal(cow2);
            // ... (weitere Tiere)

            // Farmer erstellen und Farmen zuordnen
            Farmer farmer1 = new Farmer("Hans Jakobli");
            Farmer farmer2 = new Farmer("Babettli Taburettli");

            farmer1.OwnFarm(farm1);
            farmer2.OwnFarm(farm2);

            // Tiere zu den Farmen der Bauern hinzufügen
            farmer1.AddAnimalToFarm(new Animal("Schwein1"));
            farmer1.AddAnimalToFarm(new Animal("Schwein2"));
            farmer1.AddAnimalToFarm(new Animal("Schwein3"));

            farmer2.AddAnimalToFarm(new Animal("Pferd1"));
            farmer2.AddAnimalToFarm(new Animal("Pferd2"));
            farmer2.AddAnimalToFarm(new Animal("Pferd3"));
            farmer2.AddAnimalToFarm(new Animal("Pferd4"));
            farmer2.AddAnimalToFarm(new Animal("Pferd5"));
            farmer2.AddAnimalToFarm(new Animal("Schaf1"));

            // Bauern und ihre Farmen anzeigen
            farmer1.DisplayFarmInfo();
            farmer2.DisplayFarmInfo();

            Console.ReadLine();
        }
    }
}
