using System;
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
        int scoreOne;
        int scoreTwo;

        


        //constructor
        public Game()
        {
            
        }

        //member methods
        public void Menu()
        {
            Console.WriteLine("Welcome to Rock, Paper, Sicssor, Lizrad, Spock");
            Console.WriteLine();
            Console.WriteLine("It will be best 2 out of 3");
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
            

            if (playeroneGesture == playertwoGesture)
            {
                Console.WriteLine("Tie no one gets a score.");
            }
            else if (playeroneGesture == "rock")
            {
                if(playertwoGesture == "lizard" || playertwoGesture == "scissors")
                {
                    Console.WriteLine("Player One scores");
                    scoreOne += playerOne.PlayerScore();
                }
                else if(playertwoGesture == "spock" || playertwoGesture == "paper")
                {
                    Console.WriteLine("Player Two scores");
                    scoreTwo += playerTwo.PlayerScore();
                }
            }

           
            else if (playeroneGesture == "scissors")
            {
                if (playertwoGesture == "paper" || playertwoGesture == "lizard")
                {
                    Console.WriteLine("Player One scores");
                    scoreOne += playerOne.PlayerScore();
                }
                else if(playertwoGesture == "spock" || playertwoGesture == "rock")
                {
                    Console.WriteLine("Player Two scores");
                    scoreTwo += playerTwo.PlayerScore();
                }
            }
           
            else if (playeroneGesture == "lizard")
            {
                if (playertwoGesture == "paper" || playertwoGesture == "spock")
                {
                    Console.WriteLine("Player One scores");
                    scoreOne += playerOne.PlayerScore();
                }
                else if ( playertwoGesture == "rock" || playertwoGesture == "scissors")
                {
                    Console.WriteLine("Player Two scores");
                    scoreTwo += playerTwo.PlayerScore();
                }
            }
           
            else if (playeroneGesture == "paper")
            {
                if (playertwoGesture == "spock" || playertwoGesture == "rock")
                {
                    Console.WriteLine("Player One scores");
                    scoreOne += playerOne.PlayerScore();
                }
                else if (playertwoGesture == "scissors" || playertwoGesture == "lizard")
                {
                    Console.WriteLine("Player Two scores");
                    scoreTwo += playerTwo.PlayerScore();
                }
            }
            
            else if (playeroneGesture == "spock") 
            {
                if (playertwoGesture == "scissors" || playertwoGesture == "rock")
                {
                    Console.WriteLine("Player One scores");
                    scoreOne += playerOne.PlayerScore();
                }
                else if (playertwoGesture == "lizard" || playertwoGesture == "paper")
                {
                    Console.WriteLine("Player Two scores");
                    
                    scoreTwo += playerTwo.PlayerScore();
                }
            }
            Console.ReadLine();

        }
        public void WhoWins()
        {
            if (scoreOne == 2)
            {
                Console.WriteLine("Player One Wins!!!");
            }
            else if(scoreTwo == 2)
            {
                Console.WriteLine("Player Two Wins!!!");
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
            while (scoreOne <= 2 && scoreTwo <= 2)
            {
                Console.WriteLine("Player One: " + scoreOne);
                Console.WriteLine("Player Two: " + scoreTwo);
                Rules();
                
               
            }
            if (scoreOne == 2)
            {
                Console.WriteLine("Player One Wins!!!");
                Console.ReadLine();
            }
            else if (scoreTwo == 2)
            {
                Console.WriteLine("Player Two Wins!!!");
                Console.ReadLine();
            }
            Console.WriteLine();
            
            Console.WriteLine("Would you like to play again?");
            string PlayAgain = Console.ReadLine();
            switch (PlayAgain.ToLower())
            {
                case "yes":
                    {
                        RunGame();
                        break;
                    }
                case "no":
                    {
                        Console.WriteLine("Good bye");
                        Console.ReadLine();
                        break;
                    }
                
            }
        }

    }
}
