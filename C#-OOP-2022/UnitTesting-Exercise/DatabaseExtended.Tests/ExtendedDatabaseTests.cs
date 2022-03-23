namespace DatabaseExtended.Tests
{
    using NUnit.Framework;
    using ExtendedDatabase;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {

        //NEGATIVE TESTS
        [Test]
        public void Test_AddRange_Should_Throw_Error_If_Data_Lenght_Is_Above_16()
        {
            Person[] people = new Person[17];
            //Generate people
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, i.ToString());
            }
            Assert.Throws<ArgumentException>(() =>
            {
                Database db = new Database(people);
            }, "Provided data length should be in range [0..16]!");
        }
        [Test]
        public void Test_Add_Should_Throw_Error_If_User_Tries_To_Add_More_Than_16_People()
        {
            Person[] people = new Person[16];
            //Generate people
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            Database db = new Database(people);
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(new Person(123123, "test"));
            }, "Array's capacity must be exactly 16 integers!");
        }
        [Test]
        public void Test_Add_Should_Throw_Error_If_Username_Exists_Already()
        {
            Person[] people = new Person[10];
            //Generate people
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            Database db = new Database(people);
            long UNIQUEID = 555;
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(new Person(UNIQUEID, people[^1].UserName)); //UNIQUE ID WITH NON UNIQUE NAME!
            }, "There is already user with this username!");

        }
        [Test]
        public void Test_Add_Should_Throw_Error_If_Id_Exists_Already()
        {
            Person[] people = new Person[10];
            //Generate people
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            Database db = new Database(people);
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(new Person(people[^1].Id, "TEST123213213213213124123215235"));
            }, "There is already user with this Id!");

        }
        [Test]
        public void Test_Remove_Should_Throw_Error_If_Called_On_Empty_Array()
        {
            Database db = new Database(new Person[0]);
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Remove();
            });
        }
        [Test]
        public void Test_FindByName_Should_Throw_Error_If_Username_Parameter_Is_Null()
        {
            Person p1 = new Person(1, "test");
            Person p2 = new Person(2, "t2");
            Person[] people = new Person[2] {p1,p2};
            Database database = new Database(people);
            Assert.Throws<ArgumentNullException>(() =>
            {
                database.FindByUsername(null);
            }, "Username parameter is null!");
            Assert.Throws<ArgumentNullException>(() =>
            {
                database.FindByUsername("");
            }, "Username parameter is null!");
        }
        [Test]
        public void Test_FindByName_Should_Throw_Error_If_No_User_Is_Present_By_Username()
        {
            Database db = new Database(new Person[] { new Person(1, "test") });
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.FindByUsername("usernameThatDoesNotExist");
            }, "No user is present by this username!");
        }
        [Test]
        public void Test_FindById_Should_Throw_Error_If_Id_Is_Negative()
        {
            Database db = new Database(new Person[1] { new Person(10, "test") });
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                db.FindById(-100);
            }, "Id should be a positive number!");
        }
        [Test]
        public void Test_FindById_Should_Throw_Error_If_No_User_Is_Present_By_Id()
        {
            Database db = new Database(new Person[1] { new Person(10, "test") });
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.FindById(1000);
            }, "No user is present by this ID!");
        }

        //POSITIVE TESTS
        [TestCase(0)]
        [TestCase(16)]
        public void Test_Count_Should_Return_Count(int numOfPeople)
        {
            Person[] people = new Person[numOfPeople];
            //Generate people
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            Database db = new Database(people);
            Assert.That(db.Count, Is.EqualTo(numOfPeople));
        }
        [Test]
        public void Test_Remove_Should_Decrease_Count()
        {
            Database db = new Database(new Person[] { new Person(1, "test") });
            db.Remove();
            Assert.That(db.Count, Is.EqualTo(0));
        }
        [Test]
        public void Test_FindByUsername_Should_Return_Person()
        {
            Database db = new Database(new Person[] { new Person(1, "test") });
            Assert.That(db.FindByUsername("test"), Is.TypeOf(typeof(Person)));
        }
        [Test]
        public void Test_FindById_Should_Return_Person()
        {
            Database db = new Database(new Person[] { new Person(1, "test") });
            Assert.That(db.FindById(1), Is.TypeOf(typeof(Person)));
        }

    }
}