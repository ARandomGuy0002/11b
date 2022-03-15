using NUnit.Framework;
using Skeleton;
using System;
namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack() 
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);
            Assert.AreEqual(9, axe.DurabilityPoints);
        }
        [Test]
        public void BrokenAxeCanAttack() 
        {
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);
            axe.Attack(dummy);
            axe.Attack(dummy);
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken"));
        }
    }
}