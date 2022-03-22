using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {


        [Test]
        public void Dummy_Should_Lose_Health_If_Attacked()
        {
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(1);
            Assert.That(dummy.Health, Is.EqualTo(9));
        }

        [Test]
        public void Dead_Dummy_Should_Throw_An_Exception_If_Attacked()
        {
            Dummy dummy = new Dummy(0, 10);
            //throw new InvalidOperationException("Dummy is dead.");
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.TakeAttack(100);
            }, "Dummy is dead.");
        }


        [Test]
        public void Dead_Dummy_Should_Be_Able_To_Give_XP()
        {
            Dummy dummy = new Dummy(0, 10);
            Assert.That(dummy.GiveExperience(), Is.EqualTo(10));
        }

        [Test]
        public void Alive_Dummy_Should_Not_Be_Able_To_Give_XP()
        {
            Dummy dummy = new Dummy(1, 10);
            //throw new InvalidOperationException("Target is not dead.");
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            }, "Target is not dead.");
        }





    }
}