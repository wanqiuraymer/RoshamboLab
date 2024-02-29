using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public abstract class Player
    {
        public abstract string Name { get; set; }

        public abstract Roshambo Rosh { get; set; }

        public virtual Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int intValue = random.Next(0,4);
            Rosh = (Roshambo)intValue;
            return Rosh;
        }
    }
}
