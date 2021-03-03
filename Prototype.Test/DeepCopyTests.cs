using NUnit.Framework;
using Prototype.Bows;

namespace Prototype.Test
{
    [TestFixture]
    public class DeepCopyTests
    {
        [Test]
        public void DeepCopyComplexTypeRefersNotToSameAddress()
        {
            Longbow original = ItemRegistry.Instance.GetBow("Crowfoot") as Longbow;
            Longbow clone = original.Clone(true) as Longbow;
            
            Assert.AreNotSame(original.UsedArrow, clone.UsedArrow);
            Assert.AreNotSame(original.Weight, clone.Weight);
        }
    }
}