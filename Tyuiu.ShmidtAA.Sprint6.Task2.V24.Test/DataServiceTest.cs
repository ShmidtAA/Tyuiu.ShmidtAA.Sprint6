using Tyuiu.ShmidtAA.Sprint6.Task2.V24.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double wait = -8.86;
            double res = ds.GetMassFunction(-5,5)[0];

            Assert.AreEqual(wait, res);
        }
    }
}