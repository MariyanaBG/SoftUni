using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your task is to create a Vehicle catalogue, which contains only Trucks and Cars.
            //Define a class Truck with the following properties: Brand, Model and Weight.
            //Define a class Car with the following properties: Brand, Model and Horse Power.
            //Define a class Catalog with the following properties: Collections of Trucks and Cars.
            //You must read the input until you receive the "end" command.It will be in following format: 
            //{type}/{brand}/{ model}/{ horse power / weight}
            //In the end you have to print all of the vehicles ordered alphabetical by brand, in the following format:
            //Cars:
            //{Brand}: {Model} - {Horse Power}hp
            //Trucks:
            //{Brand}: {Model} - {Weight}kg
            //Car / Audi / A3 / 110
            //Car / Maserati / Levante / 350
            //Truck / Mercedes / Actros / 9019
            //Car / Porsche / Panamera / 375
            //end
            //                                    Cars:
            //                                    Audi: A3 - 110hp
            //                                    Maserati: Levante - 350hp
            //                                    Porsche: Panamera - 375hp
            //                                    Trucks:
            //                                    Mercedes: Actros - 9019kg
            //Car / Subaru / Impreza / 152
            //Car / Peugeot / 307 / 109
            //end
            //                                    Cars:
            //                                    Peugeot: 307 - 109hp
            //                                    Subaru: Impreza - 152hp


            List<Truck> trucksCatalog = new List<Truck>();
            List<Car> carsCatalog = new List<Car>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] lineParts = line.Split('/');
                string type = lineParts[0];

                switch (type)
                {
                    case "Car":
                        Car newCar = new Car();
                        newCar.Brand = lineParts[1];
                        newCar.Model = lineParts[2];
                        newCar.HorsePower = int.Parse(lineParts[3]);
                        carsCatalog.Add(newCar);
                        break;

                    case "Truck":
                        Truck newTruck = new Truck();
                        newTruck.Brand = lineParts[1];
                        newTruck.Model = lineParts[2];
                        newTruck.Weight = int.Parse(lineParts[3]);
                        trucksCatalog.Add(newTruck);
                        break;
                }

                line = Console.ReadLine();
            }

            carsCatalog = carsCatalog.OrderBy(c => c.Brand).ToList();
            trucksCatalog = trucksCatalog.OrderBy(t => t.Brand).ToList();

            if (carsCatalog.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car currentCar in carsCatalog)
                {
                    Console.WriteLine($"{currentCar.Brand}: {currentCar.Model } - {currentCar.HorsePower}hp");
                }
            }

            if (trucksCatalog.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck currentTruck in trucksCatalog)
                {
                    Console.WriteLine($"{currentTruck.Brand}: {currentTruck.Model } - {currentTruck.Weight}kg");
                }
            }

        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }

        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }

        class Catalog
        {
            public List<Truck> trucksCatalog { get; set; }
            public List<Car> carsCatalog { get; set; }

        }
    }
}
