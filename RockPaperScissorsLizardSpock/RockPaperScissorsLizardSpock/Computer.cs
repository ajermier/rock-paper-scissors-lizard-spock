using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        //member variables

        //constructors
        public Computer()
        {
            score = 0;
            name = "Computer";
        }

        //methods
        public override int SelectShoot()
        {
            Random number = new Random();
            shootRoundNum = number.Next(1, 6);
            shootRoundName = GetShootName(shootRoundNum);

            return shootRoundNum;
        }
    }
}
