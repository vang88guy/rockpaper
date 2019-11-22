using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSicssorLizardSpock
{
    abstract class Players
    {
        //member variables
        public List<string> choices = new List<string>() { "rock", "paper", "sicssor", "lizard", "spock" };
        public int score;
        public string name;
        public string gesture;

        //constructor
        public Players()
        {
            
        }

        //member methods
        public abstract string PickGesture();

        public abstract void PickName();
        
    }
}
