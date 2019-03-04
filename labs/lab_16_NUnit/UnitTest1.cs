using NUnit.Framework;
using lab_16_NUnit_XUnit_Tests;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2,3,2,36)]
        [TestCase(5, 5, 5, 9765625)]
        [TestCase(1,1,1,1)]
        public void Lab_16_NUnit_Test_01(double x, double y, int p, double expected)
        {
            // arrange
          //  var expected = 36.0;
            var instance02 = new TestMeNow();
            // act
            var actual = instance02.TestThisMethodWorks(x, y, p);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}