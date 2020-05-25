using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split();

            var dictionary = new Dictionary<string, int>();

            while (input.ToLower() != "end")
            {
                string product = arr[0];
                int quantity = int.Parse(arr[1]);
                if (!dictionary.ContainsKey(product))
                {
                    dictionary.Add(product, quantity);
                }
                else
                {
                    dictionary[product] += quantity;
                }

                input = Console.ReadLine();
                arr = input.Split();
            }

            PrintDic(dictionary);
        }

        public static void PrintDic(Dictionary<string, int> dictionary)
        {
            foreach (var item in dictionary.OrderByDescending(key => key.Value))
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
