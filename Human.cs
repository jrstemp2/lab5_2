using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_2
{
    class Human : Player
    {
        public Human(string name /*int roshambo*/) : base(name /*roshambo*/)
        {
            this.Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            Roshambo humanChoice;
            Console.Write("Please choose an option: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Player Chooses Rock");
                return humanChoice = Roshambo.Rock;
            }
            else if (choice == 2)
            {
                Console.WriteLine("Player Chooses Paper");
                return humanChoice = Roshambo.Paper;
            }
            else
            {
                Console.WriteLine("Player Chooses Scissors");
                return humanChoice = Roshambo.Scissors;
            }
            
            
        }

        
    }
}
