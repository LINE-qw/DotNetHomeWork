using System;

namespace homework2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 3, n = 4;
            Console.WriteLine("二维数组");
            int[,] matrix1 = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            for (int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("判断结果："+JudgeMatrix(matrix1, m, n));
            Console.WriteLine("二维数组");
            int[,] matrix2 = { { 1, 2, 3, 4 }, { 5, 8, 2, 3 }, { 9, 5, 1, 2 } };
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("判断结果：" + JudgeMatrix(matrix2, m, n));
        }
        static bool JudgeMatrix(int[,] matrix,int row,int col)
        {
            for(int num=0;num<col;num++)
            {
                int i = 0 + 1, j = num + 1;
                while(i < row && j < col)
                {
                    if(matrix[i-1,j-1]!=matrix[i,j])
                    {
                        return false;
                    }
                    i++;
                    j++;
                }
            }
            for (int num = 1; num < row; num++)
            {
                int i = num + 1, j = 0 + 1;
                while (i < row && j < col)
                {
                    if (matrix[i - 1, j - 1] != matrix[i, j])
                    {
                        return false;
                    }
                    i++;
                    j++;
                }
            }
            return true;
        }
    }
}
