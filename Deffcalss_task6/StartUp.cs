using System;
using System.Collections.Generic;
using System.Linq;

namespace Deffcalss_task6
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                List<string> temp = Console.ReadLine().Split().ToList();
                string carModel = temp[0];
                int engineSpeed = int.Parse(temp[1]);
                int enginePower = int.Parse(temp[2]);
                int cargoWeight = int.Parse(temp[3]);
                string cargoType = temp[4];
                double tire1Pressure = double.Parse(temp[5]);
                int tire1Age = int.Parse(temp[6]);
                double tire2Pressure = double.Parse(temp[7]);
                int tire2Age = int.Parse(temp[8]);
                double tire3Pressure = double.Parse(temp[9]);
                int tire3Age = int.Parse(temp[10]);
                double tire4Pressure = double.Parse(temp[11]);
                int tire4Age = int.Parse(temp[12]);

                Engine currentEngine = new Engine() { EngineSpeed = engineSpeed, EnginePower = enginePower };
                Cargo currentCargo = new Cargo() { CargoWeight = cargoWeight, CargoType = cargoType };
                Tire currentTire1 = new Tire(tire1Pressure, tire1Age);
                Tire currentTire2 = new Tire(tire2Pressure, tire2Age);
                Tire currentTire3 = new Tire(tire3Pressure, tire3Age);
                Tire currentTire4 = new Tire(tire3Pressure, tire3Age);

                Car current = new Car(carModel, currentTire1, currentTire2, currentTire3, currentTire4, currentCargo, currentEngine);
                cars.Add(current);
            }

            string command = Console.ReadLine();
            //Print.Printing(command, cars);
            var result = cars.Where(x => x.Cargo.CargoType == command).First(x => x.Tiers.Any(t => t.Pressure < 1));
            var result2 = cars.Where(x => x.Cargo.CargoType ==command && x.Tiers.Any(t => t.Pressure < 1)).ToList();
            Console.WriteLine(result.CarModel);
            Console.WriteLine(result2);

        }
    }
}
