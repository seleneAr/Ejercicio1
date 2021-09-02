using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, "Electrico");
            Car car2 = new Car(4, "Gasolina");
            Motorbike motorbike = new Motorbike(2, "Gasolina");
            Truck truck = new Truck(8, "Diesel");

            List<IVehiclable> vehicles = new List<IVehiclable>();
            vehicles.Add(car);
            vehicles.Add(car2);
            vehicles.Add(motorbike);
            vehicles.Add(truck);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Fabricate());
            }
        }

        interface IVehiclable
        {
            string Fabricate();
            public int Wheels { set; get; }
            public string Fuel { set; get; }
        }

        class Car : IVehiclable
        {
            public int Wheels { get; set; }
            public string Fuel { get; set; }

            public string Fabricate()
            {
                return "Coche fabricado Ruedas: " + Wheels + " Combustible: " + Fuel;
            }

            public Car(int wheels, string fuel)
            {
                Wheels = wheels;
                Fuel = fuel;
            }
        }

        class Motorbike : IVehiclable
        {
            public int Wheels { get; set; }
            public string Fuel { get; set; }

            public string Fabricate()
            {
                return "Moto fabricada Ruedas: " + Wheels + " Combustible: " + Fuel;
            }
            public Motorbike(int wheels, string fuel)
            {
                Wheels = wheels;
                Fuel = fuel;
            }
        }

        class Truck : IVehiclable
        {
            public int Wheels { get; set; }
            public string Fuel { get; set; }

            public string Fabricate()
            {
                return "Camión fabricado Ruedas: " + Wheels + " Combustible: " + Fuel;
            }

            public Truck(int wheels, string fuel)
            {
                Wheels = wheels;
                Fuel = fuel;
            }
        }
    }
}
