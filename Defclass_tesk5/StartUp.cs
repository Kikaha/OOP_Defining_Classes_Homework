using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defclass_tesk5
{
    public class StartUp
    {

        public static void Main()
        {
            StringBuilder result = new StringBuilder();
            List<Car> cars = new List<Car>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                List<string> temp = Console.ReadLine().Split().ToList();
                string carModel = temp[0];
                int FuelAmount = int.Parse(temp[1]);
                decimal FuelCost = decimal.Parse(temp[2]);
                cars.Add(new Car() { Model = carModel, FuelAmount = FuelAmount, FuelCost = FuelCost });
            }
            string data;
            while ((data = Console.ReadLine())!="End")
            {
                List<string> temp = data.Split().ToList();
                string command = temp[0];
                string carmodel = temp[1];
                int distancetraveled = int.Parse(temp[2]);

                cars.First(x => x.Model == carmodel).Move(distancetraveled,result);
            }
            Console.WriteLine();
            Console.Write(result);
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:0.00} {car.DistanceTraveled}");
            }
        }
    }
}
//decimal fuelamount = cars.First(x => x.Model == carmodel).FuelAmount;
//decimal fuelcost = cars.First(x => x.Model == carmodel).FuelCost;
//                if (fuelamount>=distancetraveled* fuelcost)
//                {
//                    cars.First(x => x.Model == carmodel).FuelAmount -= distancetraveled* fuelcost;
//cars.First(x => x.Model == carmodel).DistanceTraveled += distancetraveled;
//                }
//                else
//                {
//                    Console.WriteLine("Insufficient fuel for the drive");
//                }