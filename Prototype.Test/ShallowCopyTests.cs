using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Prototype.Bows;
using Prototype.Swords;

namespace Prototype.Test
{
    [TestFixture]
    public class ShallowCopyTests
    {
        [Test]
        public void Test_LongbowAndCopyDamageReferenceNotSameAddress()
        {
            Longsword original = ItemRegistry.Instance.GetSword("Excalibur") as Longsword;
            Longsword clone = original.Clone() as Longsword;
            
            Assert.AreEqual(original.Damage, clone.Damage);
            Assert.AreNotSame(original.Damage, clone.Damage);
        }

        [Test]
        public void Test_CloneHasDifferentValueThanOriginalAfterChange()
        {
            Longsword original = ItemRegistry.Instance.GetSword("Excalibur") as Longsword;
            Longsword clone = original.Clone() as Longsword;

            clone.Damage = 42.0;
            original.Damage = 6.9;
            
            Assert.AreNotEqual(original.Damage, clone.Damage, $"Original: {original.Damage}, Clone: {clone.Damage}");
        }

        [Test]
        public void Test_ShallowCloneComplexTypeRefersToSameAddress()
        {
            Longbow original = ItemRegistry.Instance.GetBow("Crowfoot") as Longbow;
            Longbow clone = original.Clone() as Longbow;
            
            Assert.AreSame(original.UsedArrow, clone.UsedArrow);
            Assert.AreNotSame(original.Weight, clone.Weight);
        }
    }
}
