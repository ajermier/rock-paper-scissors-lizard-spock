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
            helper.GameTitle();
            gameType = helper.SelectGameType();

            if (gameType == 1)
            {
                helper.Get1PlayerNames(player1, player2);
            }
            else
            {
                helper.Get2PlayerNames(player1, player2);
            }

            GetGame(player1, player2);
        }

        void GetGame(Player player1, Player player2)
        {
            while (player1.score < 3 && player2.score < 3)
            {
                player1.shootRound = round.ManualShoot(player1);
                player2.shootRound = round.GetShoot(gameType, player2);
                helper.OutputShoot(player1, player2);
                ScoreRound(player1, player2);
                helper.OutputRoundSummary(player1, player2);
            }

            helper.OutputGameEnd(player1, player2);
        }

        void ScoreRound(Player player1, Player player2)
        {
            if(player1.shootRound == player2.shootRound)
            {
                helper.OutputTie();
            }
            else if (player1.shootRound == "Scissors" && (player2.shootRound == "Paper" || player2.shootRound == "Lizard"))
            {
                player1.UpdateScore();
                helper.OutputWinner(player1.name);
            }
            else if (player2.shootRound == "Scissors" && (player1.shootRound == "Paper" || player1.shootRound == "Lizard"))
            {
                player2.UpdateScore();
                helper.OutputWinner(player2.name);
            }
            else if (player1.shootRound == "Paper" && (player2.shootRound == "Rock" || player2.shootRound == "Spock"))
            {
                player1.UpdateScore();
                helper.OutputWinner(player1.name);
            }
            else if (player2.shootRound == "Paper" && (player1.shootRound == "Rock" || player1.shootRound == "Spock"))
            {
                player2.UpdateScore();
                helper.OutputWinner(player2.name);
            }
            else if (player1.shootRound == "Rock" && (player2.shootRound == "Lizard" || player2.shootRound == "Scissors"))
            {
                player1.UpdateScore();
                helper.OutputWinner(player1.name);
            }
            else if (player2.shootRound == "Rock" && (player1.shootRound == "Lizard" || player1.shootRound == "Scissors"))
            {
                player2.UpdateScore();
                helper.OutputWinner(player2.name);
            }
            else if (player1.shootRound == "Lizard" && (player2.shootRound == "Spock" || player2.shootRound == "Paper"))
            {
                player1.UpdateScore();
                helper.OutputWinner(player1.name);
            }
            else if (player2.shootRound == "Lizard" && (player1.shootRound == "Spock" || player1.shootRound == "Paper"))
            {
                player2.UpdateScore();
                helper.OutputWinner(player2.name);
            }
            else if (player1.shootRound == "Spock" && (player2.shootRound == "Scissors" || player2.shootRound == "Rock"))
            {
                player1.UpdateScore();
                helper.OutputWinner(player1.name);
            }
            else if (player2.shootRound == "Spock" && (player1.shootRound == "Scissors" || player1.shootRound == "Rock"))
            {
                player2.UpdateScore();
                helper.OutputWinner(player2.name);
            }
        }
    }
}
