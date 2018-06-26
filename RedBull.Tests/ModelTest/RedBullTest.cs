using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RedBullProject.Tests
{
    [TestClass]
    public class RedBullTest
    {
        [TestMethod]
        public void IsColumnLegit_InputIsLegit_True()
        {
            RedBull testRedBull = new RedBull();
            Assert.AreEqual(true, testRedBull.IsColumnLegit(1));
            Assert.AreEqual(false, testRedBull.IsColumnLegit(10));
            Assert.AreEqual(false, testRedBull.IsColumnLegit(123));
        }

        [TestMethod]
        public void IsRowLegit_InputIsLegit_True()
        {
            RedBull testRedBull = new RedBull();
            Assert.AreEqual(true, testRedBull.IsRowLegit("A"));
            Assert.AreEqual(true, testRedBull.IsRowLegit("a"));
            Assert.AreEqual(false, testRedBull.IsRowLegit("5"));
        }
    }
}