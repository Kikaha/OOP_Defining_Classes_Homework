using System;
using System.Collections.Generic;
using System.Text;

namespace Deffcalss_task6
{
    public class Car
    {
        private string carmodel;
        private List<Tire> tiers = new List<Tire>();
        private Cargo cargo;
        private Engine engine;

        public Car(string carmodel, Tire tire1, Tire tire2, Tire tire3, Tire tire4, Cargo cargo, Engine engine)
        {
            this.carmodel = carmodel;
            this.tiers.Add(tire1);
            this.tiers.Add(tire2);
            this.tiers.Add(tire3);
            this.tiers.Add(tire4);
            this.cargo = cargo;
            this.engine = engine;
        }
        public string CarModel => carmodel;
        public List<Tire> Tiers => tiers;
        public Cargo Cargo => cargo;
        public Engine Engine => engine;
    }
}
