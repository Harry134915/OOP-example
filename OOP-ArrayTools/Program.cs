namespace OOP_ArrayTools
{
    static class ArrayTools
    {
         public static int GetMaxID(int[] arr)
        {
            int Max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[Max])
                {
                    Max = i;
                }
            }
                return Max;
        }
        public static int GetMinID(int[] arr)
        {
            int Min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[Min])
                {
                    Min = i;
                }
            }
            return Min;
        }
        public static double GetAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayTools at = new ArrayTools();
            int[] arr = {6,3,5,7};
            //Console.WriteLine($"最大值的ID为:{at.GetMaxID(arr)}");
            //Console.WriteLine($"最小值的ID为:{at.GetMinID(arr)}");
            //Console.WriteLine($"平均值为:{at.GetAverage(arr)}");
            Console.WriteLine($"最大值的ID为:{ArrayTools.GetMaxID(arr)}");
            Console.WriteLine($"最小值的ID为:{ArrayTools.GetMinID(arr)}");
            Console.WriteLine($"平均值为:{ArrayTools.GetAverage(arr)}");
        }
    }
}
