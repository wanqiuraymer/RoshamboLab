using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public static class ValidationHandler
    {
        public static bool isValidPlayer(string input)
        {
            if (input == "j" || input == "s")
            {
                return true;
            }
            else { Console.WriteLine("Please enter valid player."); return false; }          
        }
    }
}
