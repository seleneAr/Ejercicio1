using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Motorbike motorbike = new Motorbike();
            Truck truck = new Truck();

            List<IVehiclable> vehicles = new List<IVehiclable>();
            vehicles.Add(car);
            vehicles.Add(motorbike);
            vehicles.Add(truck);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Fabricar());
            }
        }

        interface IVehiclable
        {
            string Fabricar();
        }

        class Car : IVehiclable
        {
            public string Fabricar()
            {
                return "Coche fabricado";
            }
        }

        class Motorbike : IVehiclable
        {
            public string Fabricar()
            {
                return "Moto fabricada";
            }
        }

        class Truck : IVehiclable
        {
            public string Fabricar()
            {
                return "Camión fabricado";
            }
        }
    }
}
