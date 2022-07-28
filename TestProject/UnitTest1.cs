using TestLib;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PrintClass.PrintHello();
            throw new Exception();
        }
    }
}