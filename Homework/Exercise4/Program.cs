using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[10];
            var arr1 = new int[10];
            EnterArr(arr);
            PrintArr(arr);
            Console.WriteLine("Sredno aritmetichnoto e  = " + SrednoAr(arr));
            Console.Write("Vuvedi element = ");
            int el = int.Parse(Console.ReadLine());
            if (SearchEl(arr, el) == -1) Console.WriteLine("Tozi element go nqma");
            else Console.WriteLine("Tozi element ima index " + SearchEl(arr, el));
            Prehv(arr, arr1);
            SecondMin(arr);
        }

        public static void EnterArr(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = random.Next(100);
            }
        }

        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static double SrednoAr(int[] arr)
        {
            double sr = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sr += arr[i];
            }

            return sr / arr.GetLength(0);
        }

        public static int SearchEl(int[] arr, int el)
        {
            int index = -1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (el == arr[i]) index = i;
            }

            return index;
        }

        public static void Prehv(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < Math.Max(arr1.GetLength(0), arr2.GetLength(0)); i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine();

            Console.WriteLine("Tuk sa el. ot vtoriq masiv: ");
            PrintArr(arr2);
        }

        public static void SecondMin(int[] arr)
        {
            int first, second, n = arr.Length;

            if (n < 2)
            {
                Console.Write(" Invalid Input ");
                return;
            }

            first = second = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] < second && arr[i] != first)
                    second = arr[i];
            }
            if (second == int.MaxValue)
                Console.Write("Nqma takuv el.");
            else
                Console.Write("Nai - malkiqt e " + first + " i vtoriq nai - maluk e " + second);
        }
    }
}
