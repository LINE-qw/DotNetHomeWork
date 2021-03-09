using System;

namespace homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数据：");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("素数因子为");
            Function(input);
        }
        static void Function(int num)
        {
            for(int i=2;i<=num;)
            {
                if (num % i == 0)
                {
                    num = num / i;
                    Console.Write(i + " ");
                }
                else
                    i++;
            }
        }
    }
}
