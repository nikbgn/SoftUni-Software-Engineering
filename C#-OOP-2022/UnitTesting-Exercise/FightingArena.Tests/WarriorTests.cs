namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        [Test]
        public void Test_Warrior_Constructor_Should_Work_Properly()
        {
            Warrior warrior = new Warrior("WarriorDude", 10, 10);
            Assert.That(warrior.Name, Is.EqualTo("WarriorDude"));
            Assert.That(warrior.Damage, Is.EqualTo(10));
            Assert.That(warrior.HP, Is.EqualTo(10));
        }
        [Test]
        public void Test_Warrior_Name_Getter_Should_Return_Proper_Value()
        {
            Warrior warrior = new Warrior("WarriorDude", 10, 100);
            Assert.That(warrior.Name, Is.EqualTo("WarriorDude"));
        }
        [TestCase(null)]
        [TestCase("")]
        [TestCase("                    ")]
        public void Test_Warrior_Name_Setter_Should_Throw_Error_If_Name_Is_Null_Or_Empty_Or_Whitespace(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, 10, 100);
            }, "Name should not be empty or whitespace!");
        }
        [Test]
        public void Test_Warrior_Damage_Getter_Should_Return_Proper_Value()
        {
            Warrior warrior = new Warrior("WarriorDude", 10, 100);
            Assert.That(warrior.Damage, Is.EqualTo(10));
        }
        [TestCase(0)]
        [TestCase(-1)]
        public void Test_Warrior_Damage_Setter_Should_Throw_Error_If_Damage_Is_Negative_Or_Zero(int damage)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("WarriorDude", damage, 100);
            }, "Damage value should be positive!");
        }

        [Test]
        public void Test_Warrior_HP_Getter_Should_Return_Proper_Value()
        {
            Warrior warrior = new Warrior("WarriorDude", 10, 100);
            Assert.That(warrior.HP, Is.EqualTo(100));
        }
        [Test]
        public void Test_Warrior_HP_Setter_Should_Throw_Error_If_HP_Is_Negative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("WarriorDude", 10, -1);
            }, "HP should not be negative!");
        }
        [Test]
        public void Test_Attack_Should_Throw_Error_If_Warrior_HP_Is_Less_Than_Required()
        {
            Warrior warrior1 = new Warrior("Warrior1", 10, 10);
            Warrior warrior2 = new Warrior("Warrior2", 10, 100);
            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior1.Attack(warrior2);
            }, "Your HP is too low in order to attack other warriors!");
        }
        [TestCase(10)]
        [TestCase(0)]
        [TestCase(30)]
        public void Test_Attack_Should_Throw_Error_If_Enemy_HP_Is_Less_Than_Required(int enemyHP)
        {
            Warrior warrior1 = new Warrior("Warrior1", 10, 100);
            Warrior warrior2 = new Warrior("Warrior2", 10, enemyHP);
            Assert.Catch<InvalidOperationException>(() =>
            {
                warrior1.Attack(warrior2);
            });
        }
        [Test]
        public void Test_Attack_Should_Throw_Error_If_Warrior_Attacks_Too_Powerful_Enemy()
        {
            Warrior warrior1 = new Warrior("Warrior1", 10, 100);
            Warrior warrior2 = new Warrior("Warrior2", 208, 100);
            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior1.Attack(warrior2);
            }, "You are trying to attack too strong enemy");
        }
        [Test]
        public void Test_Attack_Should_Work_Properly()
        {
            Warrior warrior1 = new Warrior("Warrior1", 10, 100);
            Warrior warrior2 = new Warrior("Warrior2", 10, 100);
            warrior1.Attack(warrior2);
            Assert.That(warrior1.HP, Is.EqualTo(90));
            Assert.That(warrior2.HP, Is.EqualTo(90));
        }
        [Test]
        public void Test_Attack_Warrior_With_More_Damage_Than_Enemy_HP_Should_Insta_Win()
        {
            Warrior warrior1 = new Warrior("Warrior1", 1000, 100);
            Warrior warrior2 = new Warrior("Warrior2", 10, 100);
            warrior1.Attack(warrior2);
            Assert.That(warrior1.HP, Is.EqualTo(90));
            Assert.That(warrior2.HP, Is.EqualTo(0));
        }
    }
}