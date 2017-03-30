using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class HelperMethods
    {
        //member variables

        //constructors
        public HelperMethods()
        {

        }

        //methods
        public void GameTitle()
        {
            Console.WriteLine("-----Rock-Paper-Scisors-Lizard-Spock-----");
            Console.WriteLine();
            Console.WriteLine("Select game type below:");
        }

        public int SelectGameType()
        {
            int choice;

            Console.WriteLine("1- Single player");
            Console.WriteLine("2- Multiplayer");
            choice = GetInput();
            Console.WriteLine();

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

        public void OutputShoot(Player player1, Player player2)
        {
            Console.WriteLine("Press Enter to Shoot");
            Console.ReadLine();
            Console.WriteLine($"{player1.name} shoots " + player1.shootRoundName);
            Console.WriteLine($"{player2.name} shoots " + player2.shootRoundName);
        }

        public void OutputTie()
        {
            Console.WriteLine();
            Console.WriteLine("TIE!");
        }

        public void OutputRoundWinner(string name)
        {
            Console.WriteLine();
            Console.WriteLine(name + " WINS!");
        }

        public void OutputRoundSummary(Player player1, Player player2)
        {
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine($"{player1.name} rounds won: {player1.score}");
            Console.WriteLine($"{player2.name} rounds won: {player2.score}");
            Console.WriteLine("----------");
            Console.WriteLine();
        }

        public void OutputGameEnd(Player player1, Player player2)
        {
            Player winner;
            Player loser;

            if(player1.score == 2)
            {
                winner = player1;
                loser = player2;
            }
            else
            {
                winner = player2;
                loser = player1;
            }
            Console.WriteLine($"GAME OVER {winner.name} wins! {winner.score}-{loser.score}");
        }

        public int GetInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Enter a number only.");
            }
            return input;
        }
    }
}
