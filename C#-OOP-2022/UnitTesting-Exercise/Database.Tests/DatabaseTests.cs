namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCase(new int[0])]
        [TestCase(new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4 })]
        public void Test_Constructor_Should_Work_With_Valid_Data(int[] parameters)
        {
            var database = new Database(parameters);
            Assert.That(database.Count, Is.EqualTo(parameters.Length));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 9, 9, 9, 9, 9, 9, 9 })]
        public void Test_Constructor_Should_Not_Work_With_Invalid_Data(int[] parameters)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var database = new Database(parameters);
            });
        }
        [Test]
        public void Test_Add_Should_Work()
        {
            var database = new Database();
            database.Add(1);
            Assert.That(database.Count, Is.EqualTo(1));
        }
        [Test]
        public void Test_Add_Should_Break_At_More_Than_16_Elements()
        {
            Database database = new Database(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(1);
            }, "Array's capacity must be exactly 16 integers!");
        }
        [Test]
        public void Test_Remove_Should_Remove_If_Elements_Are_Present()
        {
            Database database = new Database(new int[] { 1, 2, 3 });
            database.Remove();
            Assert.That(database.Count, Is.EqualTo(2));
        }
        [Test]
        public void Test_Remove_Should_Throw_Error_If_No_Elements_Are_Present()
        {
            Database database = new Database(new int[0] { });
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            }, "The collection is empty!");

        }
        [Test]
        public void Test_Fetch_Should_Return_Array()
        {
            Database db = new Database(new int[2] { 1, 2 });
            Assert.That(db.Fetch(), Is.TypeOf<int[]>());

        }



    }
}
