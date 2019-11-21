using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSicssorLizardSpock
{
    class Computer : Players
    {
        //member variables
        Random random = new Random();
        //constructor
        public Computer()
        {
                
        }

        //member methods
         public override string PickGesture()
        {
            Console.WriteLine("AI Computer will now choose a Gesture");
            gesture = random.Next(chocies.count);
            
        }

        public override string PickName()
        {
            name = "CPU";
            
        }
    }
}
