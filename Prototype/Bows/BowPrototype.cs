using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Bows
{
    public abstract class BowPrototype : IItem
    {
        public string Name { get; protected set; }
        
        public Arrow UsedArrow { get; protected set; }
        
        public Material Material { get; set; }
        public double Damage { get; protected set; }

        public double AttackRatio { get; protected set; }

        /// <summary>
        /// Create a clone of the Bow. Use [bool deep] if u want to create a deep copy in case the used Arrow changes.
        /// </summary>
        /// <param name="deep"></param>
        /// <returns></returns>
        public abstract BowPrototype Clone(bool deep = false);
    }
}
