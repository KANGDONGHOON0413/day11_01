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


            foreach (int m in arr2) Console.Write(m);

            //가변배열 선언과 초기화    
            int[][] arr4 = new int[3][] {
                new int[] {10, 20, 30},
                new int[] {12, 22, 23, 24, 25, 30},
                new int[] {0,1,2,3,4,5}
            };

            //가변배열 출력    
            for (int i = 0; i < arr4.Length; i++)
            {
                
                Console.Write("\narr[" + i + "]: ");

                //각 1차원 배열의 길이        
                for (int j = 0; j < arr4[i].Length; j++)
                {
                    Console.Write(arr4[i][j] + " ");
                }
                Console.WriteLine();

            }

        }

       
    }
}
