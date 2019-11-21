using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSicssorLizardSpock
{
    class Game
    {
        //member variables
        public string NumberOfPlayers;

        Player playerOne; 
        Player playerTwo; 
       

        //constructor
        public Game()
        {
            
        }

        //member methods
        public void Menu()
        {
            Console.WriteLine("Welcome to Rock, Paper, Sicssor, Lizrad, Spock");
            Console.WriteLine("Rules of this game \n Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
         }

        public string GetPlayers()
        {
            Console.WriteLine("Enter [1] for Player vs AI or Enter [2] for Player vs Player");

            NumberOfPlayers = Console.ReadLine();

            return NumberOfPlayers;
        }

        public void CreatePlayers(string NumberOfPlayers)
        {
            if(NumberOfPlayers == "1")
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if(NumberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
        }

        public void RunGame()
        {
            
        }

    }
}
