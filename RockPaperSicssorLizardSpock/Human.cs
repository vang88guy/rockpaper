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
        public override string PickGesture()
        {
            Console.WriteLine("Please pick a Gesture!");
            list.ForEach(i => Console.WriteLine("{0}\t" i));
            gesture = Console.ReadLine();

        }

        public override string PickName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }
    }
}
