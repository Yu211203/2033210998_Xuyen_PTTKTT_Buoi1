using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Debug_Buoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Selection Sort";
            var numbers = new[] {10, 3, 1, 7, 9, 2, 0};
            Console.Write("Mang:");
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(" " + numbers[i]);
            }

            Console.Write("\nMang giam dan:");
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int m = i;
                    int maxValue = numbers[i];

                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[j].CompareTo(maxValue) > 0)
                        {
                            m = j;
                            maxValue = numbers[j];
                        }
                    }

                    int temp = numbers[i];
                    numbers[i] = numbers[m];
                    numbers[m] = temp;
                   
                    Console.Write(" " + numbers[i]);
                }

                Console.Write("\nMang tang dan:");
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int m = i;
                    int minValue = numbers[i];

                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[j].CompareTo(minValue) < 0)
                        {
                            m = j;
                            minValue = numbers[j];
                        }
                    }

                    int temp = numbers[i];
                    numbers[i] = numbers[m];
                    numbers[m] = temp;

                    Console.Write(" " + numbers[i]);
                }

                int sum = 0;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    sum += numbers[i];
                   
                } Console.Write("\nTong mang = " + sum);

                    Console.ReadKey();
        
        }
    }
}
