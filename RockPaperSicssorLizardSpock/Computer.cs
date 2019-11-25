using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSicssorLizardSpock
{
    class Computer : Players
    {
        //member variables
        Random random = new Random();
        

        //public List<string> choices = new List<string>() { "rock", "paper", "sicssor", "lizard", "spock" };
        //constructor
        public Computer()
        {
            
        }

        //member methods

        public override void PickName()
        {
            name = "CPU";

        }
        public override string PickGesture()
        {

            Console.WriteLine(name + " will now choose a Gesture");
            Console.WriteLine();
            Console.WriteLine("Rules of this game \n Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
            Console.WriteLine();

            gesture = choices[random.Next(choices.Count)];
            Console.WriteLine(name + " picks " + gesture);
            Console.WriteLine();
            Console.ReadLine();
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
