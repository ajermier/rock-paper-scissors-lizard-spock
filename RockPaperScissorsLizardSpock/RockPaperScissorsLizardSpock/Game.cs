using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variables
        HelperMethods helper = new HelperMethods();
        Player player1 = new Player();
        Player player2 = new Player();
        Shoot round = new Shoot();
        int gameType;

        //constructors

        //methods
        public void BeginGame()
        {
            GameTitle();
            gameType = SelectGameType();

            if (gameType == 1)
            {
                Console.WriteLine("Enter player name:");
                player1.GetPlayerName();
                GetOnePlayerGame();
            }
            else
            {
                Console.WriteLine("Enter player1 name:");
                player1.GetPlayerName();
                Console.WriteLine("Enter player2 name:");
                player2.GetPlayerName();
                //GetTwoPlayerGame();
            }
        }
        int SelectGameType()
        {
            int choice;

            Console.WriteLine("1- Single player");
            Console.WriteLine("2- Multiplayer");
            choice = helper.GetInput();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Single player selected.");
                    break;
                case 2:
                    Console.WriteLine("Multiplayer selected.");
                    break;
                default:
                    Console.WriteLine("Enter a '1' or '2'.");
                    SelectGameType();
                    break;
            }
            Console.WriteLine();
            return choice;

        }

        void GameTitle()
        {
            Console.WriteLine("-----Rock-Paper-Scisors-Lizard-Spock-----");
            Console.WriteLine();
            Console.WriteLine("Select game type below:");
        }

        void GetOnePlayerGame()
        {
            while (player1.score < 3 && player2.score < 3)
            {

                Console.WriteLine($"{player1.name}'s result " + round.ManualShoot());
                Console.WriteLine("Computer's result " + round.AutoShoot());
            }
        }
    }
}
