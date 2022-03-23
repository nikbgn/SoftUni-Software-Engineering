namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ArenaTests
    {
        [Test]
        public void Test_Warrior_Getter_Should_Return_ListOfWarriors()
        {
            Arena arena = new Arena();
            arena.Enroll(new Warrior("WarriorDude", 10, 100));
            Assert.That(arena.Warriors, Is.TypeOf(typeof(List<Warrior>)));
        }
        [Test]
        public void Test_Arena_Count_Should_Return_Proper_Count()
        {
            Arena arena = new Arena();
            arena.Enroll(new Warrior("WarriorDude", 10, 100));
            Assert.That(arena.Count, Is.EqualTo(arena.Warriors.Count));
        }
        [Test]
        public void Test_Arena_Should_Enroll_Valid_Warriors()
        {
            Arena arena = new Arena();
            int initialCount = arena.Count;
            arena.Enroll(new Warrior("WarriorDude", 10, 100));
            Assert.That(arena.Count, Is.GreaterThan(initialCount));
        }
        [Test]
        public void Test_Arena_Should_Throw_Error_If_Warrior_Is_Enrolled_Already()
        {
            Arena arena = new Arena();
            arena.Enroll(new Warrior("WarriorDude", 10, 100));
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(new Warrior("WarriorDude", 10, 100));
            }, "Warrior is already enrolled for the fights!");

        }
        [Test]
        public void Test_Arena_Should_Throw_Error_If_Warrior_Name_Is_Not_Enrolled_For_Fights()
        {
            Arena arena = new Arena();
            arena.Enroll(new Warrior("AttackerGuy", 10, 100));
            arena.Enroll(new Warrior("DefenderGuy", 10, 100));
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight("aaa", "aasdasdsa");
            });
        }
        [Test]
        public void Test_Arena_Fight_Should_Work_Correctly()
        {
            Arena arena = new Arena();
            Warrior warrior1 = new Warrior("w1", 1, 100);
            Warrior warrior2 = new Warrior("w2", 1, 100);
            arena.Enroll(warrior1);
            arena.Enroll(warrior2);
            arena.Fight(warrior1.Name, warrior2.Name);
            Assert.That(warrior1.HP, Is.EqualTo(99));
            Assert.That(warrior2.HP, Is.EqualTo(99));
        }


    }
}
