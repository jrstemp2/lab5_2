using System;

namespace lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opponent;

            Console.WriteLine("Let's Play Rock, Paper, Scissors!");
            do
            {
                Console.WriteLine("Choose an Opponent: 1 for The Crusher or 2 for The Thinker: (1/2)");
                opponent = int.Parse(Console.ReadLine());
                if (opponent == 1)
                {
                    Console.WriteLine("1. Rock");
                    Console.WriteLine("2. Paper");
                    Console.WriteLine("3. Scissors");
                    PlayCrusher();
                }
                else if (opponent == 2)
                {
                    Console.WriteLine("1. Rock");
                    Console.WriteLine("2. Paper");
                    Console.WriteLine("3. Scissors");
                    PlayThinker();
                }
            } while (GoAgain());
            Console.WriteLine();
            Console.WriteLine("Thank you for playing");
        }

        static void PlayCrusher()
        {
            Human human = new Human("John");
            Crusher crush = new Crusher("The Crusher");

            Console.WriteLine("You are playing against the Crusher!");
            Roshambo hchoice = human.GenerateRoshambo();
            
            Console.WriteLine($"The Crusher Chooses {crush.GenerateRoshambo()}");

            if (hchoice == Roshambo.Rock)
            {
                Console.WriteLine("It's a Draw");
            }
            else if (hchoice == Roshambo.Paper)
            {
                Console.WriteLine("The Human Wins");
            }
            else if (hchoice == Roshambo.Scissors)
            {
                Console.WriteLine("The Crusher Wins");
            }
        }
        static void PlayThinker()
        {
            Human human = new Human("John");
            Thinker think = new Thinker("The Thinker");
            Console.WriteLine("You are playing against The Thinker!");
            Roshambo hchoice = human.GenerateRoshambo();
            Roshambo tchoice = think.GenerateRoshambo();

            if (hchoice == Roshambo.Paper && tchoice == Roshambo.Rock)
            {
                Console.WriteLine("The Human Wins");
            }
            else if (hchoice == Roshambo.Scissors && tchoice == Roshambo.Paper)
            {
                Console.WriteLine("The Human Wins");
            }
            else if (hchoice == Roshambo.Rock && tchoice == Roshambo.Scissors)
            {
                Console.WriteLine("The Human Wins");
            }

            if (tchoice == Roshambo.Paper && hchoice == Roshambo.Rock)
            {
                Console.WriteLine("The Thinker Wins");
            }
            else if (tchoice == Roshambo.Scissors && hchoice == Roshambo.Paper)
            {
                Console.WriteLine("The Thinker Wins");
            }
            else if (tchoice == Roshambo.Rock && hchoice == Roshambo.Scissors)
            {
                Console.WriteLine("The Thinker Wins");
            }
            else if (tchoice == Roshambo.Rock && hchoice == Roshambo.Rock)
            {
                Console.WriteLine("It's a Draw!");
            }
            else if (tchoice == Roshambo.Paper && hchoice == Roshambo.Paper)
            {
                Console.WriteLine("It's a Draw!");
            }
            else if (tchoice == Roshambo.Scissors && hchoice == Roshambo.Scissors)
            {
                Console.WriteLine("It's a Draw!");
            }


        }


        static bool GoAgain()
        {
            char c;
            do
            {
                Console.Write("Would you like to play again? (y/n): ");
                c = Console.ReadKey().KeyChar;
                if (c == 'n')
                {
                    return false;
                }

            } while (c != 'y');
            return true;
        }

        static void WhoWins()
        {

        }
    }
}
