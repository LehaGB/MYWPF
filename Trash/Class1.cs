using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trash
{
    class Class1
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("ВВедите размер массива: ");
            int num;
            bool n = int.TryParse(Console.ReadLine(), out num);

            int[] arr = new int[num];

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
                Console.Write($"{arr[i]} ");
            }
            int index = arr[0];

            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(index > arr[i + 1])
                {
                    int temp = index;
                    index = arr[i + 1];
                    arr[i + 1] = temp;
                }
                else
                {
                    continue;
                }
                Console.Write($"{arr[i]} ");
            }
            Console.ReadLine();
        }
    }
}
