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

        //constructors
        public Player(string name, int score, string shootRound)
        {
            this.name = GetPlayerName();
            this.score = score;
            this.shootRound = shootRound;
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
