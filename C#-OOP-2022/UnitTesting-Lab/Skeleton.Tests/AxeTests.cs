using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void Axe_Should_Lose_Durability_After_attack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10,10);
            axe.Attack(dummy);
            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack");

        }

        [Test]
        public void Axe_Should_Not_Attack_If_Broken()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);
            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            }, "Axe is broken.");
            

        }
    }
}