using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = 3;
            var arr = new int[arrSize, arrSize];
            EnterArr(arr);
            PrintArr(arr);
            ColumnMin(arr);
        }

        public static void EnterArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Enter:");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int SearchEl(int[,] arr, int el)
        {
            int value = int.MaxValue;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == el) return i;
                }
                //Console.WriteLine();
            }
            return value;
        }

        public static void ColumnMin(int[,] arr)
        {
            int min = int.MaxValue;
            var newarr = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (min > arr[j, i])
                    {
                        min = arr[j, i];
                        newarr[i] = min;
                    }
                }

                min = int.MaxValue;

                Console.WriteLine();
            }

            var res = SearchEl(arr, newarr.Min());

            if (SearchEl(arr, newarr.Min()) != int.MaxValue)
            {
                Console.WriteLine("Minimal element is from " + SearchEl(arr, newarr.Min()) + 1 + " row ");
            }
            else Console.WriteLine("Error!");

            Console.Write("New array with min elements = ");
            Console.WriteLine(string.Join(',', newarr));
        }
    }
}
