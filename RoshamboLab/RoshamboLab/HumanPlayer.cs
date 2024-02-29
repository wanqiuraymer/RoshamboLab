using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RoshamboLab
{
    internal class HumanPlayer : Player
    {
        public override string Name { get; set; }
        public override Roshambo Rosh { get; set; }

        int counter = 0;
        public override Roshambo GenerateRoshambo()
        {
            
            Console.WriteLine("Rock, paper or Scissors? (r/p/s)");
            string userGameChoice = Console.ReadLine().Trim().ToLower();
            if (counter == 3) { Console.WriteLine("Goodbye!"); Environment.Exit(0); }
            else if (counter > 0 && (userGameChoice == "r" || userGameChoice == "p" || userGameChoice == "s")) { counter = 0; }
                switch (userGameChoice)
            {
                case "r":
                    return Roshambo.Rock;
                case "p":
                    return Roshambo.Paper;
                case "s":
                    return Roshambo.Scissors;
                default:
                    Console.WriteLine("Invalid input.Try again.");
                    counter++;
                    return GenerateRoshambo();
            }
            
        }
    }
}
