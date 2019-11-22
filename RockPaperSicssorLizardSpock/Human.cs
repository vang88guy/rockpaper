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
        public override string PickGesture()
        {
            Console.WriteLine(name+"'s turn");
            Console.WriteLine();
            Console.WriteLine("Rules of this game \n Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
            Console.WriteLine();
            Console.WriteLine("Please pick a Gesture!");
            Console.WriteLine();
            //Console.WriteLine(" 1. Rock \n 2. Paper \n 3. Scissor \n 4. Lizard \n 5. Spock");
            choices.ForEach(Console.WriteLine);
            Console.WriteLine();
            gesture = Console.ReadLine();
            return gesture.ToLower();
        }

      
    }
}
