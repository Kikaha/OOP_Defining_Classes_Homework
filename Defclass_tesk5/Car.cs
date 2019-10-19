using System;
using System.Collections.Generic;
using System.Text;

namespace Defclass_tesk5
{
    public class Car
    {
        //Model, fuel amount, fuel cost for 1 kilometer and distance traveled.
        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelCost { get; set; }
        public int DistanceTraveled { get; set; }

        //this.FuelAmount >= this.FuelCost* distance ? this.DistanceTraveled += distance : Console.WriteLine("Insufficient fuel for the drive");

        public void Move(int distance, StringBuilder result)
        {
            if (this.FuelAmount>=distance*this.FuelCost)
            {
                this.FuelAmount -= distance * this.FuelCost;
                this.DistanceTraveled += distance;
            }
            else
            {
                result.AppendLine("Insufficient fuel for the drive");
            }
        }
    }
}
