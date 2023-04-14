using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    static class MergeSort
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(Func(count));
        }

        static string Func(int count)
        {
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int n = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    return "Exist";
                }
            }
            return "None";
        }


        static void MergeSortFunc<T>(this IEnumerable<T> arr, int startIndex, int endIndex)
        {
            if (endIndex == 0)
            {
                return;
            }

        }

        static void Merge(int[] arr, int startIndex, int midIndex, int endIndex)
        {

        }



    }
}
