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
        public int score;
        public string shootRoundName;
        public int shootRoundNum;
        private HelperMethods helper;

        //constructors        
        public Player()
        {

        }

        public Player (string id)
        {
            score = 0;
            this.name = GetName(id);
            helper = new HelperMethods();
        }

        //methods
        public virtual string GetName(string id)
        {
            Console.WriteLine($"Enter player{id}'s name:");
            name = Console.ReadLine();
            Console.WriteLine();

            return name;
        }

        public virtual int SelectShoot()
        {
            Console.WriteLine($"{name}, Select shoot below:");
            Console.WriteLine("1- Rock");
            Console.WriteLine("2- Paper");
            Console.WriteLine("3- Scissors");
            Console.WriteLine("4- Spock");
            Console.WriteLine("5- Lizard");

            shootRoundNum = helper.GetInput();
            shootRoundName = GetShootName(shootRoundNum);

            Console.Clear();
           
            return shootRoundNum;
        }

        public string GetShootName(int number)
        {
            switch (number)
            {
                case 1:
                    shootRoundName = "Rock";
                    break;
                case 2:
                    shootRoundName = "Paper";
                    break;
                case 3:
                    shootRoundName = "Scissors";
                    break;
                case 4:
                    shootRoundName = "Spock";
                    break;
                case 5:
                    shootRoundName = "Lizard";
                    break;
                default:
                    Console.WriteLine("Enter a '1', '2', '3', '4' or '5'.");
                    SelectShoot();
                    break;
            }
            return shootRoundName;
        }

        public void UpdateScore()
        {
            score = score + 1;
        }
    }
}
