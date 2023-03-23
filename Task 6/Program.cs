using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Task 6/1
            //Console.WriteLine("Enter size of the array:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the value for comparison:");
            //int c = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //for (int i=0; i<a.Length; i++)
            //{
            //    Console.WriteLine($"Enter the value of the array number {i+1}");
            //    a[i]=int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine($"Number lower than {c} are following:");
            //for (int i=0; i<a.Length; i++)
            //{

            //    if (a[i] < c )
            //    {
            //        Console.WriteLine(a[i]);
            //    }
            //}
            #endregion

            #region Task 6/2

            //Console.WriteLine("Enter size of the array:");
            //int n = int.Parse(Console.ReadLine()); //entered
            //Console.WriteLine("Enter the value for comparison:");
            //int c = int.Parse(Console.ReadLine()); //entered 
            //int[] a = new int[n];
            //int counter=0;
            //double average = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine($"Enter the value of the array number {i + 1}");
            //    a[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine($"The average of numbers lower than {c} is:");
            //for (int i = 0; i < a.Length; i++)
            //{

            //    if (a[i] < c)
            //    {
            //        counter++;

            //        average = (a[i] + average);
            //    }
            //}
            //average = average / counter;
            //Console.WriteLine(average);
            #endregion

            #region Task 6/3

            //Console.WriteLine("Enter size of the array:");
            //int n = int.Parse(Console.ReadLine()); //entered
            //Console.WriteLine("Enter the value for comparison:");
            //int c = int.Parse(Console.ReadLine()); //entered 
            //int[] a = new int[n];
            //int counter = 0;
            //double average = 1;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine($"Enter the value of the array number {i + 1}");
            //    a[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine($"The geometric average of numbers lower than {c} is:");
            //for (int i = 0; i < a.Length; i++)
            //{

            //    if (a[i] < c)
            //    {
            //        counter++;

            //        average = (a[i] * average);
            //    }
            //}
            //average = average / counter;
            //double newAverage = Math.Pow (average, 1.0/counter);
            //Console.WriteLine(newAverage);

            #endregion

            #region Task 6/4

            //Console.WriteLine("Enter size of the array:");
            //int n = int.Parse(Console.ReadLine()); //entered
            //Console.WriteLine("Enter the value for comparison:");
            //int c = int.Parse(Console.ReadLine()); //entered 
            //int[] a = new int[n];
            //int counter = 0;
            //double average = 1;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine($"Enter the value of the array number {i + 1}");
            //    a[i] = int.Parse(Console.ReadLine());

            //}
            //Array.Sort(a);
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Numbers higher than {c} in ascending orders are:");
            //for (int i = 0; i < a.Length; i++)
            //{

            //    if (a[i] < c)
            //    {
            //        Console.WriteLine(a[i]);
            //    }
            //}



            #endregion

            #region Task 6/5
            Console.WriteLine("Enter size of the array:");
            int n = int.Parse(Console.ReadLine()); //entered n 
            Console.WriteLine("Enter the value for comparison:");
            int c = int.Parse(Console.ReadLine()); //entered c
            int[] a = new int[n]; //creared array with n elements
            int counter = 0; //entered counter which will be used later
            


            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Enter the value of the array number {i + 1}");
                a[i] = int.Parse(Console.ReadLine()); //entered array elements

            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > c)
                {

                    
                    counter++;
                }
                
            }
            int[] aNew = new int[counter];
            counter = 0;
            for (int i=0;i<aNew.Length;i++)
            {
                if (a[i]>c)
                {
                    aNew[i] = a[i];
                    counter++;
                }
                
            }

            int maxNum =aNew.Max();
            Console.Beep();
            Console.WriteLine($"Maxmimum number among higher than {c} is {maxNum}" );

            #endregion

        }
    }
}