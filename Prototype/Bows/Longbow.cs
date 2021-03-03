using System;
using Newtonsoft.Json.Linq;

namespace Prototype.Bows
{
    public class Longbow : BowPrototype
    {
        public double Length { get;  set; }
        public double Weight { get;  set; }



        public Longbow(JToken token)
        {
            Name = token["Name"].Value<string>();
            Damage = token["Damage"].Value<double>();
            Material = (Material)Enum.Parse(typeof(Material), token["Material"].ToString());
            UsedArrow = new Arrow()
            {
                Head = (Material)Enum.Parse(typeof(Material), token["UsedArrow"]["Head"].ToString()),
                Shaft = (Material)Enum.Parse(typeof(Material), token["UsedArrow"]["Shaft"].ToString()),
                Tail = (Material)Enum.Parse(typeof(Material), token["UsedArrow"]["Tail"].ToString()),
            };
            AttackRatio = token["AttackRatio"].Value<double>();
            Length = token["Length"].Value<double>();
            Weight = token["Weight"].Value<double>();
        }

        /// <summary>
        /// Default constructor for a longbow
        /// </summary>
        /// <param name="name"></param>
        /// <param name="damage"></param>
        /// <param name="material"></param>
        /// <param name="attackRatio"></param>
        /// <param name="length"></param>
        /// <param name="weight"></param>
        public Longbow(string name, double damage, Material material, Arrow usedArrow, double attackRatio, double length, double weight)
        {
            Name = name;
            Damage = damage;
            Material = material;
            UsedArrow = usedArrow;
            AttackRatio = attackRatio;
            Length = length;
            Weight = weight;
        }

        /// <summary>
        /// Create a new longsword with given values from an existing longsword
        /// </summary>
        /// <param name="source"></param>
        /// <param name="deep"></param>
        public Longbow(Longbow source, bool deep = false)
        {
            Name = source.Name;
            Damage = source.Damage;
            Material = source.Material;
            
            AttackRatio = source.AttackRatio;
            Length = source.Length;
            Weight = source.Weight;

            if (deep)
            {
                UsedArrow = new Arrow
                {
                    Head = source.UsedArrow.Head, Tail = source.UsedArrow.Tail, Shaft = source.UsedArrow.Shaft
                };
            }
            else
            {
                UsedArrow = source.UsedArrow;
            } 
                
        }

        public override BowPrototype Clone(bool deep = false)
        {
            if (deep)
            {
                Console.WriteLine(
                    $"Deep Copying {Name} (Longbow/{Enum.GetName(typeof(Material), Material)}): It deals {Damage} Damage and has a length of {Length}cm and a weight of {Weight}g. Therefore the Attack ratio per second is {AttackRatio}");
                Longbow copy= MemberwiseClone() as Longbow;
                copy.UsedArrow = new Arrow {Head = UsedArrow.Head, Shaft = UsedArrow.Shaft, Tail = UsedArrow.Tail};
                return copy;
            }
            Console.WriteLine(
                $"Cloning {Name} (Longbow/{Enum.GetName(typeof(Material), Material)}): It deals {Damage} Damage and has a length of {Length}cm and a weight of {Weight}g. Therefore the Attack ratio per second is {AttackRatio}");
            return MemberwiseClone() as BowPrototype;
        }
    }
}
