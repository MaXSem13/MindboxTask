using Microsoft.VisualStudio.TestTools.UnitTesting;
using FugireLibrary;
using System;

namespace FigureLibraryTest
{
    [TestClass]
    public class CircleTest
    {
        Circle circle = new Circle(5);

        [TestMethod]
        public void TestSquare()
        {
            Assert.AreEqual(circle.GetSquare(), 25*Math.PI);
        }

        [TestMethod]
        public void TestGetter()
        {
            Assert.AreEqual(circle.R, 5);
        }
    }
}
