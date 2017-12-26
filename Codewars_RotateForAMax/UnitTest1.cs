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
    }
}
