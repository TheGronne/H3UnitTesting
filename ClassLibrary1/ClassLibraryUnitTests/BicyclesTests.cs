using NUnit.Framework;
using ClassLibraryUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryUnit.Tests
{
    [TestFixture()]
    public class BicycleTests
    {
        Bicycle bicycle;

        [SetUp]
        public void BeforeEachTest()
        {
            bicycle = null;
        }

        [Test()]
        public void AddBicycleTest()
        {
            BicycleShop bicycleShop = new BicycleShop();
            bicycle = new Bicycle("Racer", 3, 7, 999.99);
            bicycleShop.AddBicycle(bicycle);

            Assert.That(bicycleShop.GetBicycle(0).name == "Racer");
        }

        [Test()]
        public void GetBicycleTest()
        {
            BicycleShop bicycleShop = new BicycleShop();
            bicycle = new Bicycle("Racer", 3, 7, 999.99);
            bicycleShop.AddBicycle(bicycle);

            int id = 0;
           
            Assert.That(bicycleShop.GetBicycle(id), Is.TypeOf<Bicycle>());
            Assert.That(bicycleShop.GetBicycle(id).name == "Racer");
        }

        [Test()]
        public void GetAllBicycleTest()
        {
            BicycleShop bicycleShop = new BicycleShop();
            bicycle = new Bicycle("Racer", 3, 7, 999.99);
            bicycleShop.AddBicycle(bicycle);
            bicycle = new Bicycle("Yeet", 6, 9, 889.99);
            bicycleShop.AddBicycle(bicycle);

            int number = bicycleShop.bicycles.Count;

            Assert.That(bicycleShop.GetAllBicycles().Count == number);
            Assert.That(bicycleShop.GetAllBicycles(), Is.TypeOf<List<Bicycle>>());
            Console.WriteLine(number);
        }

        [Test()]
        public void UpdateBicycleTest()
        {
            BicycleShop bicycleShop = new BicycleShop();
            bicycle = new Bicycle("Racer", 3, 7, 999.99);
            bicycleShop.AddBicycle(bicycle);

            string name = "Yote";
            int size = 4;
            int gears = 3;
            double prize = 199999;
            int id = 0;

            bicycleShop.UpdateBicycle(name, size, gears, prize, id);

            Assert.That(bicycleShop.GetBicycle(id).name == "Yote");
        }

        [Test()]
        public void DeleteBicycleTest()
        {
            BicycleShop bicycleShop = new BicycleShop();
            bicycle = new Bicycle("Racer", 3, 7, 999.99);
            bicycleShop.AddBicycle(bicycle);
            bicycle = new Bicycle("Shuut", 5, 9, 1.99);
            int id = 0;

            bicycleShop.AddBicycle(bicycle);

            Console.WriteLine(bicycleShop.GetBicycle(id).name);
            Console.WriteLine(bicycleShop.GetBicycle(id + 1).name);

            bicycleShop.DeleteBicycle(id);

            Console.WriteLine(bicycleShop.GetBicycle(id).name);

            Assert.That(bicycleShop.GetBicycle(id).name == "Shuut");
        }
    }
}