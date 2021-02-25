using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Swords
{
    public class Longsword : SwordPrototype
    {
        public double Length { get; private set; }

        /// <summary>
        /// Default constructor for a longsword
        /// </summary>
        /// <param name="name"></param>
        /// <param name="damage"></param>
        /// <param name="material"></param>
        /// <param name="attackRatio"></param>
        /// <param name="length"></param>
        public Longsword(string name, double damage, Material material, double attackRatio, double length)
        {
            Name = name;
            Damage = damage;
            Material = material;
            AttackRatio = attackRatio;
            Length = length;
        }

        /// <summary>
        /// Create a new longsword with given values from an existing longsword
        /// </summary>
        /// <param name="source"></param>
        public Longsword(Longsword source)
        {
            Name = source.Name;
            Damage = source.Damage;
            Material = source.Material;
            AttackRatio = source.AttackRatio;
            Length = source.Length;
        }

        public override SwordPrototype Clone()
        {
            Console.WriteLine(
                $"Cloning {Name} (Longsword/{Enum.GetName(typeof(Material), Material)}): It deals {Damage} Damage and has a length of {Length}. Therefore the Attack ratio per second is {AttackRatio}");
            return MemberwiseClone() as SwordPrototype;
        }
    }
}
