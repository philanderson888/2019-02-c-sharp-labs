using System;
using Xunit;
using lab_16_NUnit_XUnit_Tests;

namespace lab_16_XUnit
{
    public class Lab_16_XUnit_Tests
    {
        [Fact]
        public void Lab_16_Test_Math_Power()
        {
            // arrange
            var instance01 = new TestMeNow();
            var expected01 = 9765625;


            // act
            var actual01 = instance01.TestThisMethodWorks(5, 5, 5);

            // assert
            Assert.Equal(expected01, actual01);
        }
    }
}
