using Tyuiu.ShmidtAA.Sprint6.Task0.V12.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 1.741;
            Assert.AreEqual(wait,res);

        }
    }
}