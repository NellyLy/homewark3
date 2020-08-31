using System;
using System.Runtime.CompilerServices;

namespace Test1
{
    class Program
    {
       
        static void Main()
        {
            
            string a;
            Console.WriteLine("Please enter the size of an array that you whant to sort");

           

            Random r = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i=0; i< n; i++)
            {
                arr[i] = r.Next(0, 9);
                Console.WriteLine(arr[i] + "");
            }
            Console.WriteLine("Select which algorithm you whant to perform 1.Insertion sort 2.Bubble sort 3.Merge sort");
            a = Console.ReadLine();
            if (a == "1")
            {
                

              //  Console.WriteLine("Please enter the size of an array that you whant to sort again");

                Class1 ob = new Class1();
                ob.sort(arr);


                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine(arr[i] + "");
                }



            }

            else if (a == "2")
            {
                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine(arr[i] + "");
                }
                Console.WriteLine("Please enter the size of an array that you whant to sort again");
                Class2 ba = new Class2();
                ba.bubbleSort(arr);

                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine(arr[i] + "");
                }

            }
            else if (a=="3")
            {
                Console.WriteLine("Please enter the size of an array that you whant to sort again");
                Class3 fe = new Class3();
                fe.mergeSort();


                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine(arr[i] + "");
                }

            } else
            {
                Console.WriteLine("Sorry try again '1','2','3'");
            }


        }

      
    }

   
}

