using Microsoft.VisualStudio.TestTools.UnitTesting;
using FugireLibrary;

namespace FigureLibraryTest
{
    [TestClass]
    public class TriangleTest
    {
        Triangle triangle = new Triangle(3, 4, 5);

        [TestMethod]
        public void TestGetter()
        {           
            Assert.AreEqual(triangle.A, 3);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            Assert.AreEqual(triangle.GetPerimeter(), 12);
        }

        [TestMethod]
        public void TestSquare()
        {
            Assert.AreEqual(triangle.GetSquare(), 6);
        }

        [TestMethod]
        public void TestRectangular()
        {
            Assert.AreEqual(triangle.IsRectangular(), true);
            Triangle t = new Triangle(5, 6, 14);
            Assert.AreEqual(t.IsRectangular(), false);
        }
    }
}
