using System;
using System.Collections.Generic;
using System.Text;

namespace Defclass_tesk11
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public string Name => name;
        public string Element => element;
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }
        public override string ToString()
        {
            return $"{this.name}{this.element} {this.health}";
        }
    }
}
