using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player
    {
        //member variables
        public string name;
        public int score = 0;
        public string shootRound;
        public int shootRoundNum;

        //constructors
        public Player(string name, int score, string shootRound, int shootRoundNum)
        {
            this.name = GetPlayerName();
            this.score = score;
            this.shootRound = shootRound;
            this.shootRoundNum = shootRoundNum;
        }
        
        public Player()
        {

        }

        //methods
        public string GetPlayerName()
        {
            return name = Console.ReadLine();
        }

        public void UpdateScore()
        {
            score = score + 1;
        }
    }
}
