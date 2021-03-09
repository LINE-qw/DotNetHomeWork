using System;

namespace homework2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数组：");
            int[] array1 = { 2, 4, 6, 8, 2, 7 };
            for(int i=0;i<array1.Length;i++)
                Console.Write(array1[i]+" ");
            Console.WriteLine();
            Max(array1, array1.Length);
            Min(array1, array1.Length);
            AverageSum(array1, array1.Length);
        }
        static void Max(int[] input,int length)
        {
            int max = input[0];
            for(int i=1;i<length;i++)
            {
                if (input[i] > max)
                    max = input[i];
            }
            Console.WriteLine($"最大值为：{max}");
        }
        static void Min(int[] input, int length)
        {
            int min = input[0];
            for (int i = 1; i < length; i++)
            {
                if (input[i] < min)
                    min = input[i];
            }
            Console.WriteLine($"最小值为：{min}");
        }
        static void AverageSum(int[] input, int length)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = input[i] + sum;
            }
            Console.WriteLine($"平均值为：{(double)sum/(double)length}");
            Console.WriteLine($"元素和为：{sum}");
        }
    }
}
