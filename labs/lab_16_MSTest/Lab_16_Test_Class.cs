using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_16_NUnit_XUnit_Tests;
using System;

namespace lab_16_MSTest
{
    [TestClass]
    public class Lab_16_Test_Class
    {
        [TestInitialize]
        public void Initialize()
        {
            Console.WriteLine("Initializing Tests");
        }

        [TestMethod]
        public void TestLab16UsingMSTest()
        {
            // arrange
            var expected = 216.0;
            var instance01 = new TestMeNow();

            // act
            var actual = instance01.TestThisMethodWorks(2, 3, 3);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Console.WriteLine("Cleaning up after tests have run");
        }
    }
}
