using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trash
{
    class Program
    {
        static Random rnd = new Random();
        static int[] arr;
        static void Main(string[] args)
        {
            Print(arr);
        }
        private static int[] FillingArray()
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
          
            arr = new int[n];
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 101);
                Console.Write($"{arr[i]} ");
            }
            return arr;
        }
        private static void Print(int[] arr)
        {
            arr = FillingArray();
            Console.WriteLine("\n");
            Console.WriteLine("Упорядоченный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.Write($"{arr[i]} ");
            }
            Console.ReadLine();
        }
    }
}
