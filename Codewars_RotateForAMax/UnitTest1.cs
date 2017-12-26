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

        [TestMethod]
        public void Input_321_Should_Be_321()
        {
            Assert.AreEqual(321,Kata.MaxRot(321));
        }

        [TestMethod]
        public void Input_9876543210000000000_Should_Be_9876543210000000000()
        {

            Assert.AreEqual(987654321000000000, Kata.MaxRot(987654321000000000));
        }

    }
}
