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
        private HelperMethods helper;
        private Player player1;
        private Player player2;

        private int gameType;

        //constructors
        public Game()
        {
            helper = new HelperMethods();
        }

        //methods
        public void BeginGame()
        {
            helper.GameTitle();
            gameType = helper.SelectGameType();

            if (gameType == 1)
            {
                player1 = new Player("");
                player2 = new Computer();
            }
            else if (gameType == 2)
            {
                player1 = new Player(" 1");
                player2 = new Player(" 2");
            }

            GetGame(player1, player2);
        }

        private void GetGame(Player player1, Player player2)
        {
            while (player1.score < 2 && player2.score < 2)
            {
                player1.SelectShoot();
                player2.SelectShoot();
                helper.OutputShoot(player1, player2);
                ScoreRoundAlgorithm(player1, player2);
                helper.OutputRoundSummary(player1, player2);
            }

            helper.OutputGameEnd(player1, player2);
        }

        private void ScoreRoundAlgorithm(Player player1, Player player2)
        {
            int check = (5 + (player1.shootRoundNum-1) - (player2.shootRoundNum-1)) % 5;

            if(check == 1 || check == 3)
            {
                player1.UpdateScore();
                helper.OutputRoundWinner(player1.name);
            }
            else if(check == 2 || check == 4)
            {
                player2.UpdateScore();
                helper.OutputRoundWinner(player2.name);
            }
            else
            {
                helper.OutputTie();
            }

        }

        private void ScoreRound(Player player1, Player player2)
        {
            if(player1.shootRoundName == player2.shootRoundName)
            {
                helper.OutputTie();
            }
            else if (player1.shootRoundName == "Scissors" && (player2.shootRoundName == "Paper" || player2.shootRoundName == "Lizard"))
            {
                player1.UpdateScore();
                helper.OutputRoundWinner(player1.name);
            }
            else if (player2.shootRoundName == "Scissors" && (player1.shootRoundName == "Paper" || player1.shootRoundName == "Lizard"))
            {
                player2.UpdateScore();
                helper.OutputRoundWinner(player2.name);
            }
            else if (player1.shootRoundName == "Paper" && (player2.shootRoundName == "Rock" || player2.shootRoundName == "Spock"))
            {
                player1.UpdateScore();
                helper.OutputRoundWinner(player1.name);
            }
            else if (player2.shootRoundName == "Paper" && (player1.shootRoundName == "Rock" || player1.shootRoundName == "Spock"))
            {
                player2.UpdateScore();
                helper.OutputRoundWinner(player2.name);
            }
            else if (player1.shootRoundName == "Rock" && (player2.shootRoundName == "Lizard" || player2.shootRoundName == "Scissors"))
            {
                player1.UpdateScore();
                helper.OutputRoundWinner(player1.name);
            }
            else if (player2.shootRoundName == "Rock" && (player1.shootRoundName == "Lizard" || player1.shootRoundName == "Scissors"))
            {
                player2.UpdateScore();
                helper.OutputRoundWinner(player2.name);
            }
            else if (player1.shootRoundName == "Lizard" && (player2.shootRoundName == "Spock" || player2.shootRoundName == "Paper"))
            {
                player1.UpdateScore();
                helper.OutputRoundWinner(player1.name);
            }
            else if (player2.shootRoundName == "Lizard" && (player1.shootRoundName == "Spock" || player1.shootRoundName == "Paper"))
            {
                player2.UpdateScore();
                helper.OutputRoundWinner(player2.name);
            }
            else if (player1.shootRoundName == "Spock" && (player2.shootRoundName == "Scissors" || player2.shootRoundName == "Rock"))
            {
                player1.UpdateScore();
                helper.OutputRoundWinner(player1.name);
            }
            else if (player2.shootRoundName == "Spock" && (player1.shootRoundName == "Scissors" || player1.shootRoundName == "Rock"))
            {
                player2.UpdateScore();
                helper.OutputRoundWinner(player2.name);
            }
        }
    }
}
