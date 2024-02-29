using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class RockPlayer : Player
    {
        public override string Name { get; set; }
        public override Roshambo Rosh { get ; set ; }

        public RockPlayer(string name) 
        { 
            Name = name;
            Rosh = Roshambo.Rock;
        }


        
    }
}
