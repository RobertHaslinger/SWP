using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Swords
{
    public class MiddleswordObjectAdapter : IFightable, IGlowable
    {
        private Middlesword _sword;

        public MiddleswordObjectAdapter(Middlesword sword)
        {
            _sword = sword;
        }

        public string Fight()
        {
            return _sword.Attack();
        }

        public string Glow()
        {
            return "Not all swords glow, but this one surely does.";
        }
    }
}
