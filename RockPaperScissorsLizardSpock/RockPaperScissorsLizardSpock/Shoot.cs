using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Shoot
    {
        //member variables
        HelperMethods helper = new HelperMethods();
        string result;

        //constructors

        //methods
        public string GetShoot(int gameType, Player player)
        {
            if (gameType == 1)
            {
                return AutoShoot(player);
            }
            else
            {
                return ManualShoot(player);
            }
        }
        public string ManualShoot(Player player)
        {
            return GetShootResult(SelectShoot(player), player);
        }

        public string AutoShoot(Player player)
        {
            Random number = new Random();
            player.shootRoundNum = number.Next(1, 6);
            return GetShootResult(player.shootRoundNum, player);
        }

        int SelectShoot(Player player)
        {

            Console.WriteLine($"{player.name}, Select shoot below:");
            Console.WriteLine("1- Rock");
            Console.WriteLine("2- Paper");
            Console.WriteLine("3- Scissors");
            Console.WriteLine("4- Spock");
            Console.WriteLine("5- Lizard");

            player.shootRoundNum = helper.GetInput();

            Console.Clear();

            Console.WriteLine();
            return player.shootRoundNum;
        }

        string GetShootResult(int number, Player player)
        {
            switch (number)
            {
                case 1:
                    result = "Rock";
                    break;
                case 2:
                    result = "Paper";
                    break;
                case 3:
                    result = "Scissors";
                    break;
                case 4:
                    result = "Spock";
                    break;
                case 5:
                    result = "Lizard";
                    break;
                default:
                    Console.WriteLine("Enter a '1', '2', '3', '4' or '5'.");
                    SelectShoot(player);
                    break;
            }
            return result;
        }
    }
}
