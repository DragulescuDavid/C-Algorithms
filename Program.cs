using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        public static bool BS(int[] array, int left, int right, int x)
            //for searching a number x in array we split the array into half by comparing x to array[middle]
            //to specify in which half of the array we should be searching(the array is sorted), and we do that until we find x or we can't split array anymore
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                if (array[middle] == x)
                {
                    Console.WriteLine("Poisition: ", middle);
                    return true;
                }

                else
                {
                    if (array[middle] > x)
                        return BS(array, left, middle - 1, x);
                    else
                        return BS(array, middle + 1, right, x);
                }

            }
            else
                return false;
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int x;
            bool final;
            for (int i = 0; i < array.Length; ++i)
                array[i] = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            final = BS(array, 0, array.Length - 1, x);
            if (final == true)
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not found");
            Console.ReadKey();
        }
    }
}
