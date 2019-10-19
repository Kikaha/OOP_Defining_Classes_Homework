using System;
using System.Collections.Generic;
using System.Text;

namespace Deffclass_task7
{
    public class Engine
    {
        //has model, power, displacement and efficiency.
        private string model;
        private int power;
        private int displacement; //opt
        private string efficience;  //opt

        public Engine(string model, int power)
            :this(model,power,-1,"n/a")
        {
        }

        public Engine(string model, int power, int displacement)
            :this(model,power,-1 ,"n/a")
        {
        }

        public Engine(string model, int power, int displacement, string efficence)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficience = efficence;
        }

        public string Model => model;
        public int Power => power;
        public int Displacement => displacement;
        public string Efficience => efficience;

    }
}
