using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Class2
    {
       public static void bubbleSort(int[] arr)
        {
            int size = int.Parse(Console.ReadLine());
            int n = size;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i] 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        
    }
}
