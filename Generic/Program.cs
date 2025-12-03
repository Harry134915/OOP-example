namespace Generic
{
    internal class Program
    {
        public static void Swap<T>(ref T a,ref T b)
        {
            T temp = b;
            b = a;
            a = temp;
        }

        static void NoRefSwap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int m = 10, n = 30;
            Swap<int>(ref m, ref n);
            Console.WriteLine($"m={m},n={n}");


        }
    }
}




