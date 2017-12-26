using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_RotateForAMax
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_1_Should_Be_1()
        {
            Assert.AreEqual(1,Kata.MaxRot(1));   
        }

        [TestMethod]
        public void Input_12_Should_Be_21()
        {
            Assert.AreEqual(21,Kata.MaxRot(12));
        }

        [TestMethod]
        public void Input_123_Should_Be_231()
        {
            Assert.AreEqual(231,Kata.MaxRot(123));
        }

        [TestMethod]
        public void Input_21_Should_Be_21()
        {
            Assert.AreEqual(21,Kata.MaxRot(21));
        }

    }
}
