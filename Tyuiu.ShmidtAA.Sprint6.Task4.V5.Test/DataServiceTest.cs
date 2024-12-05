using Tyuiu.ShmidtAA.Sprint6.Task4.V5.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double wait = 70.14;
            double res = ds.GetMassFunction(-5, 5)[0];
            Assert.AreEqual(wait, res);

        }
    }
}