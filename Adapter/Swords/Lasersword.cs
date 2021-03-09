using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Swords
{
    public class Lasersword : IFightable, IGlowable
    {
        public string Fight()
        {
            return "The lasersword burns the skin of its target.";
        }

        public string Glow()
        {
            return
                "As you concentrate on your inner strength, your sword starts to burst out lasers in all directions!";
        }
    }
}
