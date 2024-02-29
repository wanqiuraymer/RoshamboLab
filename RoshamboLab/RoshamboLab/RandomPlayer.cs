using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class RandomPlayer : Player
    {
        public override string Name { get; set; }
        public override Roshambo Rosh { get; set; }

        public RandomPlayer(string name)
        {
            Name = name;
            
        }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int intValue = random.Next(0, 2);
            Rosh = (Roshambo)intValue;       
            return Rosh;
        }
    }
}
