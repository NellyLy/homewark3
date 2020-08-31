using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Class1
    {
        public void sort(int[] arr)

        {
            int size = int.Parse(Console.ReadLine());
            int n = size;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
       



    }
   
}
  
