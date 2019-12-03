using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };

            // Console.WriteLine(LinearSearch(arr, 9));
            
            SelectionSort(arr);
        }

        public static int LinearSearch(int[] arr, int val)
        {
            for(int i= 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int min, int max, int val)
        {
            var mid = ((max + min) + 1) / 2;

            if (max < min)
                return -1;
            else if (arr[mid] == val)
                return mid;
            else if (val < arr[mid])
            {
                // min = min;
                max = mid - 1;
                return BinarySearch(arr, min, max, val);
            }
            else
            {
                min = mid + 1;
                return BinarySearch(arr, min, max, val);
            }
        }

        public static void BubbleSort(int[] arr)
        {
            printArray(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        var temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            printArray(arr);
        }


        public static void SelectionSort(int[] arr)
        {
            printArray(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var mini = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[mini] > arr[j])
                    {
                        mini = j;
                    }
                }
                var temp = arr[mini];
                arr[mini] = arr[i];
                arr[i] = temp;
            }
            printArray(arr);
        }
        private static void printArray(int[] arr)
        {
            var str = string.Join(" ,", arr);
            Console.WriteLine("["+ str + "]");
        }
    }
}
