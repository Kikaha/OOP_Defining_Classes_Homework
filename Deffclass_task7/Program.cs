using System;
using System.Collections.Generic;
using System.Linq;

namespace Deffclass_task7
{
    public class Program
    {
        public static void Main()
        {
            List<Engine> engines = new List<Engine>();
            //Engine in the following format “< Model > < Power > < Displacement > < Efficiency >”.
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                List<string> temp = Console.ReadLine().Split().ToList();
                string modelEngine = temp[0];
                int powerEngine = int.Parse(temp[1]);
                int displacementEngine = int.Parse(temp[2]);
                if (temp.Count == 3)
                {
                    engines.Add(new Engine(modelEngine, powerEngine, displacementEngine));
                }
                else
                {
                    engines.Add(new Engine(modelEngine, powerEngine, displacementEngine, temp[3]));
                }
            }
            //temp.Count==3?engines.Add(new Engine(modelEngine,powerEngine,displacementEngine)):engines.Add(new Engine(modelEngine,powerEngine,displacementEngine,temp[3]));
            List<Car> cars = new List<Car>();
            int Mnumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < Mnumber; i++)
            {
                List<string> temp = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                string carModel = temp[0];
                string carengineModel = temp[1];
                var engineToAdd = engines.First(x => x.Model == carengineModel);
                //< Model > < Engine > < Weight > < Color >
                if (temp.Count==2)
                {
                    cars.Add(new Car(carModel, engineToAdd));
                }
                else if (temp.Count==3)
                {
                    if (temp[2] is string)
                    {
                        cars.Add(new Car(carModel, engineToAdd, temp[2]));
                    }
                    else
                    {
                        cars.Add(new Car(carModel, engineToAdd, int.Parse(temp[2])));
                    }
                }
                else
                {
                    cars.Add(new Car(carModel, engineToAdd, int.Parse(temp[2]), temp[3]));
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"<{car.Model}>");
                Console.WriteLine($" <{car.Engine.Model}>");
                Console.WriteLine($"  Power:<{car.Engine.Power}>");
                Console.WriteLine("  Displacement: {0}", car.Engine.Displacement==-1 ? "n/a": car.Engine.Displacement.ToString());                                    //{car.Engine.Displacement}
                Console.WriteLine($"  Efficency:<{car.Engine.Efficience}>");
                Console.WriteLine(" Weight: {0}", car.Weight==-1 ? "n/a" :car.Weight.ToString());
                Console.WriteLine($" Color:<{car.Color}>");
            }


        }
    }
}
