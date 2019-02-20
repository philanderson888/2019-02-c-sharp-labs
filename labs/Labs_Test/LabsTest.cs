using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_112_collections;
using lab_113_arraylist;

namespace Labs_Test
{
    [TestClass]
    public class LabsTest
    {
        [TestMethod]
        public void Lab112CollectionsTest01()
        {
            // arrange
            var expected01 = 22400;
            var instance01Lab112Collection = new Collections();
            // act
            double actual01 = instance01Lab112Collection.Collections20MinuteLab(10, 20, 30);
            // assert
            Assert.AreEqual(expected01, actual01);
        }
        [TestMethod]
        public void Lab112CollectionsTest02()
        {
            // arrange
            double expected02 = 6944;
            var instance02Lab112Collection = new Collections();
            // act
            double actual02 = instance02Lab112Collection.Collections20MinuteLab(11, 12, 13);
            // assert
            Assert.AreEqual(expected02, actual02);
        }
        [TestMethod]
        public void Lab113ArrayListTest()
        {
            // arrange
            var expected = 48000;
            var instanceLab113 = new arraylist();
            // act
            var actual = instanceLab113.arraylistMethod(10, 20, 30, 40);
            // assert
            Assert.AreEqual(expected,actual);
        }
    }
}
