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
    private static void Main(string[] args)
    {
        Penjumlahan test = new Penjumlahan();
        Console.WriteLine(test.JumlahTigaAngka<double>(13,2,22));
    }
}