using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSicssorLizardSpock
{
    class Human : Players
    {
        //member variables
        
        //constructor
        public Human()
        {
            
        }

        //member methods
        public override void PickName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            
            
        }
        public static bool BetweenRanges(int a, int b, int number)
        {
            return (a <= number && number <= b);
        }

        public override string PickGesture()
        {
            
            Console.WriteLine(name + "'s turn");
            Console.WriteLine();
            Console.WriteLine("Rules of this game \n Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
            Console.WriteLine();
            Console.WriteLine("Please pick a Gesture!");
            Console.WriteLine();
            Console.WriteLine(" 1. rock \n 2. paper \n 3. scissors \n 4. lizard \n 5. Spock");
            ///choices.ForEach(Console.WriteLine);
            Console.WriteLine();
            var PlayerGest = Console.ReadLine();
            int playerGesture;
            
            
                while (!int.TryParse(PlayerGest, out playerGesture))
                {

                    Console.WriteLine("Not a number");
                    PlayerGest = Console.ReadLine();

                }
            
            gesture = choices[playerGesture - 1];
            Console.WriteLine(name + " picks " + gesture);
            Console.WriteLine();
            Console.Clear();
            return gesture;
            
        }
        public override int PlayerScore()
        {
            score++;
            return score;
        }

    }
}
