using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_2
{
    class Crusher : Player
    {

        
        
        public Crusher(string name) : base(name)
        {
            this.Name = name;
        }
        public override Roshambo GenerateRoshambo()
        {
            Roshambo crushChoice = Roshambo.Rock;
            return crushChoice;
        }
    }
}
