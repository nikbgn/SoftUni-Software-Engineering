namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        [Test]
        public void Test_Make_Should_Return_Correct_Value()
        {
            Car car = new Car("BMW", "I8", 6.7, 42);
            Assert.That(car.Make, Is.EqualTo("BMW"));
        }

        [TestCase (null)]
        [TestCase ("")]
        public void Test_Make_Should_Throw_Error_If_Null_Or_Empty(string invalidMake)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car(invalidMake, "I8", 6.7, 42);
            }, "Make cannot be null or empty!");
        }


        [Test]
        public void Test_Model_Should_Return_Correct_Value()
        {
            Car car = new Car("BMW", "I8", 6.7, 42);
            Assert.That(car.Model, Is.EqualTo("I8"));
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test_Model_Should_Throw_Error_If_Null_Or_Empty(string invalidModel)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("BMW", invalidModel, 6.7, 42);
            }, "Model cannot be null or empty!");
        }



        [Test]
        public void Test_FuelConsumption_Should_Return_Correct_Value()
        {
            Car car = new Car("BMW", "I8", 6.7, 42);
            Assert.That(car.FuelConsumption, Is.EqualTo(6.7));
        }

        [TestCase(0)]
        [TestCase(-100)]
        public void Test_FuelConsumption_Should_Throw_Error_If_Zero_Or_Negative(double invalidFuelConsumption)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("BMW", "I8", invalidFuelConsumption, 42);
            }, "Fuel consumption cannot be zero or negative!");
        }


        [Test]
        public void Test_FuelCapacity_Should_Return_Correct_Value()
        {
            Car car = new Car("BMW", "I8", 6.7, 42);
            Assert.That(car.FuelCapacity, Is.EqualTo(42));
        }

        [TestCase(0)]
        [TestCase(-100)]
        public void Test_FuelCapacity_Should_Throw_Error_If_Zero_Or_Negative(double invalidFuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("BMW", "I8", 6.7, invalidFuelCapacity);
            }, "Fuel capacity cannot be zero or negative!");
        }

        [TestCase(10)]
        public void Test_FuelAmount_Should_Return_Correct_Value(int refuelWith)
        {
            Car car = new Car("BMW", "I8", 6.7, 42);
            car.Refuel(refuelWith);
            Assert.That(car.FuelAmount, Is.EqualTo(refuelWith));
        }

        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(400000)]
        public void Test_Refuel_Should_Stop_Refueling_At_FuelCapacity(int refuelWith)
        {
            Car car = new Car("BMW", "I8", 6.7, 42);
            car.Refuel(refuelWith);
            Assert.That(car.FuelAmount, Is.EqualTo(car.FuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void Test_Refuel_Should_Throw_Error_If_Value_Is_Zero_Or_Negative(int refuelWith)
        {
            Car car = new Car("BMW", "I8", 6.7, 42);
            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(refuelWith);
            }, "Fuel amount cannot be zero or negative!");
        }

        [Test]
        public void Test_Drive_Should_Reduce_FuelAmount()
        {
            Car car = new Car("BMW", "I8", 6.7, 42);
            double refuelWith = 40;
            car.Refuel(refuelWith);
            double distance = 10;
            double fuelNeeded = (distance / 100) * car.FuelConsumption;
            car.Drive(distance);
            Assert.That(car.FuelAmount, Is.EqualTo(refuelWith - fuelNeeded));
        }
        [Test]
        public void Test_Drive_Should_Throw_Error_If_Not_Enough_Fuel()
        {
            Car car = new Car("BMW", "I8", 6.7, 42);
            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(100);
            }, "You don't have enough fuel to drive!");
        }


        //throw new InvalidOperationException("You don't have enough fuel to drive!");


    }
}