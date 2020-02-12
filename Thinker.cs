using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_2
{
    class Thinker : Player
    {

        protected static Random random;

        public Thinker(string name) : base(name)
        {
            this.Name = name;
        }

        
        public override Roshambo GenerateRoshambo()
        {

            random = new Random();
            int choice = random.Next(1, 4);

            Roshambo thinkChoice;
            if (choice == 1)
            {
                Console.WriteLine("Thinker Chose Rock");
                return thinkChoice = Roshambo.Rock;
            }
            else if (choice == 2)
            {
                Console.WriteLine("Thinker Chose Paper");
                return thinkChoice = Roshambo.Paper;
            }
            else
            {
                Console.WriteLine("Thinker Chose Scissors");
                return thinkChoice = Roshambo.Scissors;
            }
        }
    }
}
