using System;
using System.Collections.Generic;
using System.Text;

namespace Defclass_tesk11
{
    public class Trainer
    {
        private string name;
        private int numberBadges;
        private List<Pokemon> pokemons = new List<Pokemon>();

        public Trainer(string name)
        {
            this.name = name;
            this.numberBadges = 0;
        }

        public string Name => name;
        public int NumberOfBadges
        {
            get { return this.numberBadges; }
            set { this.numberBadges = value;}
        }
 
        public List<Pokemon> Pokemons => pokemons;
        public override string ToString()
        {
            return $"{this.name} {this.numberBadges} {this.Pokemons.Count}";
        }

    }
}
