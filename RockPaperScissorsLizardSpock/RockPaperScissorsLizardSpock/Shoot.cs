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

        //constructors

        //methods
        public int ManualShoot()
        {
            return GetShootResult(SelectShoot());
        }

        public int AutoShoot()
        {
            Random number = new Random();
            int choice = number.Next(1, 6);
            return GetShootResult(choice);
        }

        int SelectShoot()
        {
            int choice;

            Console.WriteLine("Select shoot below:");
            Console.WriteLine("1- Rock");
            Console.WriteLine("2- Paper");
            Console.WriteLine("3- Scissors");
            Console.WriteLine("4- Lizard");
            Console.WriteLine("5- Spock");

            choice = helper.GetInput();

            Console.WriteLine();
            return choice;
        }

        int GetShootResult(int selectedChoice)
        {
            switch (selectedChoice)
            {
                case 1:
                    Console.WriteLine("Rock selected.");
                    break;
                case 2:
                    Console.WriteLine("Paper selected.");
                    break;
                case 3:
                    Console.WriteLine("Scissors selected.");
                    break;
                case 4:
                    Console.WriteLine("Lizard selected.");
                    break;
                case 5:
                    Console.WriteLine("Spock selected.");
                    break;
                default:
                    Console.WriteLine("Enter a '1', '2', '3', '4' or '5'.");
                    SelectShoot();
                    break;
            }
            return selectedChoice;
        }
    }
}
