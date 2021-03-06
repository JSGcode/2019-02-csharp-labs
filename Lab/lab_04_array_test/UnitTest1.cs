﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_04_array;

namespace Lab_04_array_test
{
    // attribute : declaration
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_Array_Sum()
        {
            // arrange (setup)
            var arrayInstance = new Lab_04_array.Array();
            var expectedOutput = 285;
            // act (run code)
            var actualOutput = arrayInstance.CreateArray(10);

            // assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Check_Array_Sum_Variable_Size()
        {
            // arrange (setup)
            var arrayInstance = new Lab_04_array.Array();
            var expectedOutput = 2470;
            // act (run code)
            var actualOutput = arrayInstance.CreateArray(20);

            // assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }

}
