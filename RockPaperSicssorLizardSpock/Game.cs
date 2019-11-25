﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSicssorLizardSpock
{
    class Game
    {
        //member variables
        public string NumberOfPlayers;
        
        Players playerOne; 
        Players playerTwo;

        


        //constructor
        public Game()
        {
            
        }

        //member methods
        public void Menu()
        {
            Console.WriteLine("Welcome to Rock, Paper, Sicssor, Lizrad, Spock");
            Console.WriteLine();
            Console.WriteLine("Rules of this game \n Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
            Console.WriteLine(); 
        }

        public void GetPlayers()
        {
            Console.WriteLine("Enter [1] for Player vs AI or Enter [2] for Player vs Player");

            NumberOfPlayers = Console.ReadLine();

           
      
            if(NumberOfPlayers == "1")
            {
               playerOne = new Human();
               playerTwo = new Computer();
                
            }
            else if(NumberOfPlayers == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            Console.Clear();
        }

        public void Rules()
        {
            string playeroneGesture = playerOne.PickGesture();
            string playertwoGesture = playerTwo.PickGesture();
            //OneGesture = playerOne.PickGesture();
            //TwoGesture = playerTwo.PickGesture();

            if (playeroneGesture == playertwoGesture)
            {
                Console.WriteLine("Tie no one gets a score.");
            }
            else if (playeroneGesture == "rock" && playertwoGesture == "lizrad" || playertwoGesture == "scissors")
            {
                Console.WriteLine("Player One wins");
                playerOne.PlayerScore();
            }

            else if (playeroneGesture == "rock" && playertwoGesture == "spock" || playertwoGesture == "paper")
            {
                Console.WriteLine("Player Two Wins");
                playerTwo.PlayerScore();
            }
            else if (playeroneGesture == "scissors" && playertwoGesture == "paper" || playertwoGesture == "lizard")
            {
                Console.WriteLine("Player One Wins");
                playerOne.PlayerScore();
            }
            else if (playeroneGesture == "scissors" && playertwoGesture == "spock")
            {
                Console.WriteLine("Player Two Wins");
                playerTwo.PlayerScore();
            }
            else if (playeroneGesture == "lizard" && playertwoGesture == "paper" || playertwoGesture == "spock")
            {
                Console.WriteLine("Player One Wins");
                playerOne.PlayerScore();
            }

            else if (playeroneGesture == "paper" && playertwoGesture == "spock")
            {
                Console.WriteLine("Player One Wins");
                playerOne.PlayerScore();
            }
            else if (playeroneGesture == "paper" && playertwoGesture == "scissors" || playertwoGesture == "lizard")
            {
                Console.WriteLine("Player Two Wins");
                playerTwo.PlayerScore();
            }
            else if () 
            {
                
            }
        }

        public void RunGame()
        {
            Menu();
            GetPlayers();
            playerOne.PickName();
            Console.Clear();
            playerTwo.PickName();
            Console.Clear();
            Rules();
        }

    }
}
