using System.ComponentModel.DataAnnotations;

internal class Program
{
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            this.storedData.Add(data);
            this.inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 1; i <= storedData.Count; i++)
            {
                Console.WriteLine("Baris " + i + " berisi: " + storedData[i-1] + ", yang disimpan pada waktu UTC: " + inputDates[i-1] + " AM");
            }
        }
    }
    private static void Main(string[] args)
    {
        SimpleDataBase<double> test = new SimpleDataBase<double>();
        test.AddNewData(13);
        test.AddNewData(02);
        test.AddNewData(22);
        test.PrintAllData();
    }
}