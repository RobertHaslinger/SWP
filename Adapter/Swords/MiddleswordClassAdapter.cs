using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Swords
{
    /// <summary>
    /// Class adapter for the outdated Middlesword
    /// </summary>
    public class MiddleswordClassAdapter : Middlesword, IFightable, IGlowable
    {
        public string Fight()
        {
            return Attack();
        }

        public string Glow()
        {
            return "Not all swords glow, but this one surely does.";
        }
    }
}
