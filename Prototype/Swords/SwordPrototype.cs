using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Swords
{
    public abstract class SwordPrototype : IItem
    {
        public string Name { get; protected set; }

        public double Damage { get; protected set; }

        public double AttackRatio { get; protected set; }

        public Material Material { get; protected set; }

        public abstract SwordPrototype Clone();
    }
}
