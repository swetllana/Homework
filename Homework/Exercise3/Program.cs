using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] arr = input.Split(' ');
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (!dictionary.ContainsKey(arr[i]))
                {
                    dictionary.Add(arr[i], 1);
                }
                else
                {
                    dictionary[arr[i]]++;
                }
            }

            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
