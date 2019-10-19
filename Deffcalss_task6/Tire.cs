using System;
using System.Collections.Generic;
using System.Text;

namespace Deffcalss_task6
{
    public class Tire
    {
        private double pressure;
        private int age;

        public Tire(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }

        public double Pressure => pressure;
        public int Age => age;
    }
}

//public double Tire1Pressure { get; set; }
//public double Tire2Pressure { get; set; }
//public double Tire3Pressure { get; set; }
//public double Tire4Pressure { get; set; }
//public int Tire1Age { get; set; }
//public int Tire2Age { get; set; }
//public int Tire3Age { get; set; }
//public int Tire4Age { get; set; }
