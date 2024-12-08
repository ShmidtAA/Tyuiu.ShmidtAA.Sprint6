using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShmidtAA.Sprint6.Task6.V15.Lib
{
    public class DataService : ISprint6Task6V15
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";
            
            using(StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] lineArray = line.Split(' ');
                    result += lineArray[lineArray.Length-1];
                }
            }
            return result;
        }
    }
}
