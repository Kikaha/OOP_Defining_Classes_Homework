using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                List<string> temp = Console.ReadLine().Split().ToList();
                people.Add(new Person() { Name = temp[0], Age = int.Parse(temp[1]) });
            }
            people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));

            var result = people.GroupBy(x => x.Age > 30).ToList();
            foreach (var group in result)
            {
                if (group.Key == true)
                {
                    foreach (var memeber in group.OrderBy(x => x.Name))
                    {
                        Console.WriteLine($"{memeber.Name} - {memeber.Age}");
                    }
                }
            }
        }
    }
}
