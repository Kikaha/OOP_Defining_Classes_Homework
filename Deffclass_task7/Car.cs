using System;
using System.Collections.Generic;
using System.Text;

namespace Deffclass_task7
{
    public class Car
    {
        //A Car has a model, engine, weight and color
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine):this(model, engine, -1, "n/a")
        {
        }

        public Car(string model, Engine engine, int weight):this(model,engine, -1, "n/a")//string.Empty
        {

        }

        public Car(string model, Engine engine, string color):this(model, engine, color, -1)
        {

        }
        public Car(string model, Engine engine, string color, int weight )
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }


        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public string Model => model;
        public Engine Engine => engine;
        public int Weight => weight;
        public string Color => color;

    }
}
