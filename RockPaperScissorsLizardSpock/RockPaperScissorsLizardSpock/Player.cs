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

        //constructors
        public Player(string name, int score)
        {
            this.name = GetPlayerName();
            this.score = score;
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
