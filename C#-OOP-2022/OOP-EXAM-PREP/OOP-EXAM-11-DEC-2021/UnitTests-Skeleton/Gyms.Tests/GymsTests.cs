namespace Gyms.Tests
{
    using NUnit.Framework;
    using System;
    public class GymsTests
    {

        [TestCase("")]
        [TestCase(null)]
        public void Test_Invalid_Gym_Name_Throws_Error(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Gym gym = new Gym(name, 1);
            });
        }
        [Test]
        public void Test_Invalid_Gym_Capacity_Throws_Error()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Gym gym = new Gym("aa", -1);
            });
        }
        [Test]
        public void Test_Count_Of_Athletes_Works()
        {
            Gym gym = new Gym("g", 2);
            gym.AddAthlete(new Athlete("a1"));
            gym.AddAthlete(new Athlete("a2"));
            Assert.That(gym.Count, Is.EqualTo(2));
        }
        [Test]
        public void Test_Add_Athlete_Throws_Error_If_Full()
        {
            Gym gym = new Gym("a", 1);
            gym.AddAthlete(new Athlete("a1"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.AddAthlete(new Athlete("a2"));

            });
        }
        [Test]
        public void Test_Remove_Athlete_Throws_Error_If_Not_Found()
        {
            Gym gym = new Gym("a", 2);
            gym.AddAthlete(new Athlete("a1"));
            gym.AddAthlete(new Athlete("a2"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.RemoveAthlete("jajjjqwjfqwjfqw");
            });
        }
        [Test]
        public void Test_Injure_Athlete_Throws_Error_If_Not_Found()
        {
            Gym gym = new Gym("a", 2);
            gym.AddAthlete(new Athlete("a1"));
            gym.AddAthlete(new Athlete("a2"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.InjureAthlete("qwdjqwodqwiojiodqwjiojdioqwoi");
            });
        }
        [Test]
        public void Test_Report_Shows_Only_Non_Injured_Athletes()
        {
            Gym gym = new Gym("a", 2);
            gym.AddAthlete(new Athlete("a1"));
            gym.AddAthlete(new Athlete("a2"));
            gym.InjureAthlete("a2");
            Assert.That($"Active athletes at a: a1", Is.EqualTo(gym.Report()));
        }
        [Test]
        public void Test_Injure_Athlete_Works_Properly()
        {
            Gym gym = new Gym("a", 2);
            gym.AddAthlete(new Athlete("a1"));
            gym.AddAthlete(new Athlete("a2"));
            Assert.That(gym.InjureAthlete("a2"), Is.TypeOf<Athlete>());
        }
        [Test]
        public void Test_Add_Athlete_Works_Properly()
        {
            Gym gym = new Gym("a", 3);
            gym.AddAthlete(new Athlete("1"));
            Assert.That(gym.Count, Is.EqualTo(1));
        }
        [Test]
        public void Test_Remove_Athlete_Works_Properly()
        {
            Gym gym = new Gym("a", 3);
            gym.AddAthlete(new Athlete("1"));
            gym.AddAthlete(new Athlete("2"));
            gym.RemoveAthlete("2");
            Assert.That(gym.Count, Is.EqualTo(1));
        }
    }
}
