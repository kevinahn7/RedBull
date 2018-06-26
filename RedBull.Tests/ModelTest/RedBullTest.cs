using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedBullProject;

namespace RedBullProject.Tests
{
    [TestClass]
    public class RedBullTest
    {
        [TestMethod]
        public void IsLegitInput_InputIsLegit_True()
        {
            RedBull testRedBull = new RedBull();
            Assert.AreEqual(true, testRedBull.IsLegitInput("A"));
        }
    }
}