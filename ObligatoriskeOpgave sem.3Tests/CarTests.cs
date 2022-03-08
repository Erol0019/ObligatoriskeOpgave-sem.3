using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskeOpgave_sem._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskeOpgave_sem._3.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void LicensePlateTest()
        {
            Car car = new Car(1, "Opel", 1500, "AA12345");
            car.LicensePlate = "AA12345";
            Assert.AreEqual("AA12345", car.LicensePlate);
            car.LicensePlate = "AA";
            Assert.AreEqual("AA", car.LicensePlate);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "12345678");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "1");


        }

        [TestMethod()]
        public void ModelTest()
        {
            Car car = new Car(2, "Opel", 2000, "BB12345");
            car.Model = "Opel";
            Assert.AreEqual("Opel", car.Model);

            car.Model = "Mercedes";
            Assert.AreEqual( "Mercedes", car.Model);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Model = "5");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Model = "1");
        }
        [TestMethod()]
        public void PriceTest()
        {
            Car car = new Car(3, "Audi", 2000, "BB12345");
            car.Price = 2000;
            Assert.AreEqual(2000, car.Price);

            /*car.Price = 3000;
            Assert.AreEqual(3000, car.Price);
            */

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Price = 0);
        }
        [TestMethod()]
        public void IdTest()
        {
            Car car = new Car(4, "Audi", 2000, "BB12345");
            car.Id = 4;
            Assert.IsInstanceOfType(car.Id, typeof(int));

          // Assert.ThrowsException<ArgumentException>(() => car.Id = 4);
        }
    }
}