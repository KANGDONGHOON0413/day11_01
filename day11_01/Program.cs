using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11_01
{
    class Program
    {
        private static int[] CreateArray1(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++) arr[i] = i;
            return arr;
        }
         private static int[,] CreateArray2(int v1, int v2)
        {
            int[,] arr = new int[v1, v2];
            for (int i = 0; i < v1; i++)
                for (int j = 0; j < v2; j++) arr[i, j] = i * v2 + j;
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr1;
            int[,] arr2;

            arr1 = CreateArray1(5);
            arr2 = CreateArray2(2, 3);
            for (int i = 0; i < arr1.Length; i++) Console.Write(arr1[i]);
            Console.WriteLine();

            for(int i = 0; i < 2; i++)
            {
                for(int j =0; j < 3; j++)
                {
                    Console.Write(arr2[i, j]);
                }
                Console.WriteLine();
            }
        }

       
    }
}
