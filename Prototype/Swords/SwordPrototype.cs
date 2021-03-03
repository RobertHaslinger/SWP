using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Swords
{
    public abstract class SwordPrototype : IItem
    {
        public string Name { get;  set; }

        public double Damage { get;  set; }

        public double AttackRatio { get;  set; }

        public Material Material { get;  set; }

        public abstract SwordPrototype Clone();
    }
}
