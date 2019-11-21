using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSicssorLizardSpock
{
    class  Player
    {
        //member variables
        public List<string> choices = new List<string>() { "rock", "paper", "sicssor", "lizard", "spock" };
        public int score;
        public string name;
        public string gesture;

        //constructor
        public Player()
        {
            
        }

        //member methods
        public abstract void PickGesture();

        public abstract void PickName();
        
    }
}
