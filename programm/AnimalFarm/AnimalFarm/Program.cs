using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace AnimalFarm
{
    public class Program
    {
        private static List<Animal> Animals;
        private static List<Building> Buildings;
        private static List<Farmer> Farmers;
        private static List<Vehicle> Vehicles;

        public Program()
        {
            Animals = new List<Animal>();
            Buildings = new List<Building>();
            Farmers = new List<Farmer>();
            Vehicles = new List<Vehicle>();
        }

        public static void Main(string[] args)
        {
            GetStartMessage();

            string doExample = AskUser("Sollen wir eine Vorprogrammierte weise verwenden? [Ja(j)/Nein(n)]");
            if(doExample.ToUpper() == "J" || doExample.ToUpper() == "JA")
            {
                Console.Clear();
                GetExample();
            }
            else
            {
                Console.Clear();
                bool isCorrectInput = false;
                string respons = "";
                while (respons.ToUpper() != "EXIT")
                {
                    do
                    {
                        GetSettings();
                        respons = AskUser("Wähle eine Zahl!");
                        isCorrectInput = CheckSettingInput(respons);
                    } while (!isCorrectInput);

                    ExecuteTask(respons);
                }
            }
        }

        public static void GetSettings()
        {
            Console.Clear();
            Console.WriteLine("1. Add Building");
            Console.WriteLine("2. Add Farmer");
            Console.WriteLine("3. Add Vehicle");
            Console.WriteLine("4. Add Animal");
            Console.WriteLine("5. Get All");
        }

        public static bool CheckSettingInput(string input)
        {
            bool isCorrect;
            switch (input.ToUpper())
            {
                case "1":
                    Console.WriteLine(input);
                    isCorrect = true;
                    break;

                case "2":
                    isCorrect = true;
                    break;

                case "3":
                    isCorrect = true;
                    break;

                case "4":
                    isCorrect = true;
                    break;

                case "5":
                    isCorrect = true;
                    break;

                case "EXIT":
                    isCorrect = true;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Deine Eingabe ist nicht korrekt!");
                    Thread.Sleep(2000);
                    isCorrect = false;
                    break;
            }
            return isCorrect;
        }

        public static void ExecuteTask(string task)
        {
            switch (task)
            {
                case "1":
                    Building building = new Building();
                    Buildings.Add(building);
                    Console.Clear();
                    Console.WriteLine("Building wurde hinzugefügt");
                    Thread.Sleep(1000);
                    break;

                case "2":
                    Console.Clear();
                    string name = AskUser("Gib dem Farmer einen Namen");
                    Farmer farmer = new Farmer(name);
                    Farmers.Add(farmer);

                    if(Buildings.Count > 0)
                    {
                        string respons = AskUser("Soll der Farmer einem Haus zugeordnet werden? [Ja(j)/Nein(n)]");
                        if (respons.ToUpper() == "J" || respons.ToUpper() == "JA")
                        {
                            foreach (var housing  in Buildings)
                            {
                                foreach(var farmMaster in Farmers)
                                {
                                    if(farmMaster.Farm == null)
                                    {
                                        farmMaster.AddToBuilding(housing);
                                    }
                                }
                            }
                        }

                    }
                    Thread.Sleep(1000);
                    break;

                case "3":
                    Console.Clear();
                    Vehicle vehicle = new Vehicle("Fahrzeug" + Vehicles.Count);

                    string FarmersName = AskUser($"Zu welchem Farmer willst du das {vehicle.Name} zuweisen?");
                    Farmer farmer1 = Farmers.Find(x => x.Name == FarmersName);
                    farmer1.SetVehicle(vehicle);
                    Thread.Sleep(1000);
                    break;

                case "4":
                    Console.Clear();
                    string AnimalName = AskUser("Welches Tier möchtest du erstellen?");
                    Animal animal = new Animal(AnimalName + Animals.Count);

                    Animals.Add(animal);

                    string FarmersName2 = AskUser("Zu welchem Farmer möchtest du das Tier zuweisen?");
                    Farmer farmer2 = Farmers.Find(x => x.Name == FarmersName2);
                    farmer2.AddAnimalToFarm(animal);
                    Thread.Sleep(1000);
                    break;

                case "5":
                    Console.Clear();
                    foreach (var farmMaster in Farmers)
                    {
                        if(farmMaster.Farm != null)
                        {
                            farmMaster.DisplayFarmInfo();
                        }
                    }
                    Console.ReadLine();
                    break;
            }
        }

        public static string AskUser(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static void GetStartMessage()
        {
            Console.WriteLine("Hallo bei AnimalFarm!");

            Thread.Sleep(2000);

            Console.Clear();
        }

        public static void GetExample()
        {
            // Erstellen von Tieren
            Animal cow1 = new Animal("Kuh1");
            Animal cow2 = new Animal("Kuh2");

            // Erstellen von Gebäuden (Farmen)
            Building farm1 = new Building();
            Building farm2 = new Building();

            // Tiere zu den Farmen hinzufügen
            farm1.AddAnimal(cow1);
            farm1.AddAnimal(cow2);

            // Farmer erstellen und Farmen zuordnen
            Farmer farmer1 = new Farmer("Hans Jakobli");
            Farmer farmer2 = new Farmer("Babettli Taburettli");

            farmer1.AddToBuilding(farm1);
            farmer2.AddToBuilding(farm2);

            // Fahrzeuge zu dem Bauernhof hinzufügen
            Vehicle vehicle1 = new Vehicle("Fahrzeug1");
            Vehicle vehicle2 = new Vehicle("Fahrzeug2");

            farmer1.SetVehicle(vehicle1);
            farmer2.SetVehicle(vehicle2);
            vehicle2.AddToBuilding(farm2);


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
