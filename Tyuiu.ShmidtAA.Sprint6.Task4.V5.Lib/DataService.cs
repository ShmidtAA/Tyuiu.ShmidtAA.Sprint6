using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShmidtAA.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = Math.Abs(startValue) + stopValue + 1;
            double[] resArray = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((3 * i + 1.2) == 0)
                {
                    resArray[count] = 0;
                }
                else
                {
                    resArray[count] = ((2 * Math.Sin(i)) / (3 * i + 1.2)) + Math.Cos(i) - 7 * i * 2;
                }
                resArray[count] = Math.Round(resArray[count], 2);
                count++;

            }
            return resArray;
        }
    }
}
