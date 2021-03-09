using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Swords
{
    public class Longsword : IFightable, IGlowable
    {
        public string Fight()
        {
            return "The longsword slices through the enemy.";
        }

        public string Glow()
        {
            return "As the sun goes down, you can see the sword starting to lighten up.";
        }
    }
}
