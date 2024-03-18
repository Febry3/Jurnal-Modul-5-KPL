
internal class Program
{
    public class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;
            return tempA + tempB + tempC;
        }
    }
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

        Penjumlahan test = new Penjumlahan();
        Console.WriteLine(test.JumlahTigaAngka<double>(13,2,22));

        SimpleDataBase<double> test1 = new SimpleDataBase<double>();
        test1.AddNewData(13);
        test1.AddNewData(02);
        test1.AddNewData(22);
        test1.PrintAllData();
    }
}