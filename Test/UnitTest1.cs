using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        public object Github_demo { get; private set; }

        [TestMethod]
        public void Devide_Test()
        {
            // AAA A-arrange; A-Act; A-assert
            int expected = 25;
            int num = 100;
            int denom = 4;

            // act
           //int actual = Github_demo. Program.Devide(num, denom);

           // Assert.AreEqual(expected, actual);
        }
    }
}
