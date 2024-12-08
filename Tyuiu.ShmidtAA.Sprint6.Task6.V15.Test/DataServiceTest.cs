using Tyuiu.ShmidtAA.Sprint6.Task6.V15.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "D:\\Загрузки\\InPutDataFileTask6V15.txt";
            DataService ds = new DataService();
            string wait = "HlidZPHKeLLUOoyPFhjSRwpGUilXwwiukCfOUaZNpcgYjw";

            Assert.AreEqual(wait,ds.CollectTextFromFile(path));
        }
    }
}