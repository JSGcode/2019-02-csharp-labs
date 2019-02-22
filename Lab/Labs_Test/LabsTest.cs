using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_112_collections;
using Lab_113_ArrayList;

namespace Labs_Test
{
    [TestClass]
    public class LabsTest
    {
        [TestMethod]
        public void Lab112CollectionTests()
        {
            //  arrange 
            var expected01 = 22400;
            var expected02 = 6944;
            var instanceLab112Collection = new Collections();

            //  act
            var actual01 = instanceLab112Collection.Collection20MniuteLab(10,20,30);
            var actual02 = instanceLab112Collection.Collection20MniuteLab(11,12,13);
            
            //  assert
            Assert.AreEqual(expected01, actual01);
            Assert.AreEqual(expected02, actual02);
        }

        [TestMethod]
        public void Lab113ArrayListTests()
        {
            //  arrange 
            var expected = 48000;
            var instanceLab113 = new ArrayListClass();
            //  act
            var actual = instanceLab113.ArrayListMethod(10, 20, 30, 40);
            //  assert
            Assert.AreEqual(expected, actual);
        }
    }
}
