using System;

namespace homework2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2-100内素数:");
            int[] number=new int[101];
            number[0] = 0;
            number[1] = 0;
            for (int i = 2; i <= 100; i++)
            {
                number[i] = i;
            }
            JudgePrime(number);
        }
        static void JudgePrime(int[] num)
        {
            for(int i=2;i<=100;i++)
            {
                int j = 2;
                while (i*j<=100)
                {
                    num[i * j] = 0;
                    j++;
                }
            }
            for (int i = 2; i <= 100; i++)
            {
                if(num[i]!=0)
                {
                    Console.Write(num[i] + " ");
                }
            }
        }
    }
}
