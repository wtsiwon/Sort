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
            int[] arr = new int[10] { 1, 6, 2, 8, 5, 4, 3, 9, 10, 7 };

            SortArray(arr, 0, arr.Length - 1);


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //재귀함수 연습
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

        /// <summary>
        /// 정렬
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);//앞부터 중간까지
                SortArray(array, middle + 1, right);//중간부터 끝까지

                MergeArray(array, left, middle, right);//합치기~
            }

            return array;
        }

        public static void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;//비교할 첫번째 배열의 길이
            var rightArrayLength = right - middle;//비교할 두번째 배열의 길이
            var leftTempArray = new int[leftArrayLength];//비교할 첫번째 배열
            var rightTempArray = new int[rightArrayLength];//비교할 두번째 배열
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];//실질적인 값 저장
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];//실질적인 값 저장

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])//왼쪽이 더 작다면
                {
                    array[k++] = leftTempArray[i++];//왼쪽값를 배열에 저장한다
                }
                else
                {
                    array[k++] = rightTempArray[j++];//아니면 오른쪽값을 배열에 저장
                }
            }

            //여기에 오게되면 왼쪽이나 오른쪽중 한쪽이 다 없어짐

            while (i < leftArrayLength)//왼쪽이 남아 있는 경우
            {
                array[k++] = leftTempArray[i++];//남아있는 값 넣어주기
            }

            while (j < rightArrayLength)//오른쪽이 남아 있는 경우
            {
                array[k++] = rightTempArray[j++];//남아 있는 값 넣어주기
            }
        }
    }
}
