using Tyuiu.ShmidtAA.Sprint6.Task7.V9.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "D:\\Загрузки\\InPutDataFileTask7V9.csv";
            DataService ds = new DataService();
            int[] waitArray = { -14, -16, 8, 7, 7, -13, -17, 18, 11, 17 };
            int[,] matrix = ds.GetMatrix(path);
            int[] resultArray = new int[matrix.GetLength(0)];
            
            for(int i = 0; i < matrix.GetLength(0); i++) // уточнить как работает GetLength() 
            {
                resultArray[i] = matrix[i, 2];
            }
            CollectionAssert.AreEqual(waitArray, resultArray);


        }
    }
}