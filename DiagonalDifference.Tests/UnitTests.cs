using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DiagonalDifference
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SampleData()
        {
            var dataMatrix = new List<List<int>>() {
                new List<int>() {11,2,4},
                new List<int>() { 4,5,6},
                new List<int>() { 10,8,-12} };

            Assert.AreEqual(15, DiagonalDifference.DiagonalDifferenceFunction.DiagonalDifference(dataMatrix));
        }
    }
}
