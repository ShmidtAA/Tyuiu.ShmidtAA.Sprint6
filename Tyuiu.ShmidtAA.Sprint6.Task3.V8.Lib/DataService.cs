using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShmidtAA.Sprint6.Task3.V8.Lib
{
    public class DataService : ISprint6Task3V8
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[3,i]%2==0)
                {
                    matrix[3,i] = 0;
                }
            }
            return matrix;


        }
    }
}
