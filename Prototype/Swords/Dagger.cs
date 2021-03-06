﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Prototype.Bows;

namespace Prototype.Swords
{
    public class Dagger : SwordPrototype
    {
        public double CurveAngle { get;  set; }
        public double Sharpness { get;  set; }

        public Dagger(JToken token)
        {
            Name = token["Name"].Value<string>();
            Damage = token["Damage"].Value<double>();
            Material = (Material)Enum.Parse(typeof(Material), token["Material"].ToString());
            AttackRatio = token["AttackRatio"].Value<double>();
            CurveAngle = token["CurveAngle"].Value<double>();
            Sharpness = token["Sharpness"].Value<double>();
        }

        /// <summary>
        /// Default constructor for a dagger
        /// </summary>
        /// <param name="name"></param>
        /// <param name="damage"></param>
        /// <param name="material"></param>
        /// <param name="attackRatio"></param>
        /// <param name="curveAngle"></param>
        /// <param name="sharpness"></param>
        public Dagger(string name, double damage, Material material, double attackRatio, double curveAngle, double sharpness)
        {
            Name = name;
            Damage = damage;
            Material = material;
            AttackRatio = attackRatio;
            CurveAngle = curveAngle;
            Sharpness = sharpness;
        }

        /// <summary>
        /// Create a new dagger with given values from an existing dagger
        /// </summary>
        /// <param name="source"></param>
        public Dagger(Dagger source)
        {
            Name = source.Name;
            Damage = source.Damage;
            Material = source.Material;
            AttackRatio = source.AttackRatio;
            CurveAngle = source.CurveAngle;
            Sharpness = source.Sharpness;
        }
        
        public override SwordPrototype Clone()
        {
            Console.WriteLine(
                $"Cloning {Name} (Dagger/{Enum.GetName(typeof(Material), Material)}): Its blade has a curve of {CurveAngle}° and the sharpness is {Sharpness}%. The Attack ratio per second is {AttackRatio} and the resulting damage is {Damage}");
            return MemberwiseClone() as SwordPrototype;
        }
    }
}
