using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> peoples = new List<Employee>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {                
                List<string> temp = Console.ReadLine().Split().ToList();
                if (temp.Count==5)
                {
                    peoples.Add((new Employee(temp[0], decimal.Parse(temp[1]), temp[2], temp[3],temp[4])));
                }
                else if (temp.Count == 4)
                {
                    peoples.Add((new Employee(temp[0], decimal.Parse(temp[1]), temp[2], temp[3])));
                }
                else
                {
                    peoples.Add((new Employee(temp[0], decimal.Parse(temp[1]), temp[2], temp[3], temp[4], int.Parse(temp[5]))));
                }
            }
            var result = peoples.GroupBy(x => x.Department)
                .Select(x => new { Department = x.Key, AverageSelary = x.Average(e => e.Salary), Employe = x. OrderByDescending(em => em.Salary) })
                /*.OrderByDescending(x => x.AverageSelary)*/.FirstOrDefault();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Highest Average Salary: {result.Department}");
            foreach (var members in result.Employe)
            {
                Console.WriteLine($"{members.Name} {members.Salary} {members.Department} {members.Email}");
            }
        }
    }
}
