using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_2
{
    abstract class Player
    {
        private string name;
        

        public string Name { get => name; set => name = value; }
        

        protected Player(string name)
        {
            this.name = name;
            
        }

        public abstract Roshambo GenerateRoshambo();

        public override string ToString()
        {
            return $"Player Name: {name}";
        }
    }
}
