using System;
using System.Collections.Generic;
using System.Text;

namespace CABasicexamples
{
    class example9
    {
        static void Main()
        {
            /*  int a, b, c;//swapping of 2 numbers with third variable
              Console.Write("enter a and b values to swap ");
              a = Convert.ToInt32(Console.ReadLine());
              b = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("the numbers before swapping are {0},{1} ", a, b);
              c = a;
              a = b;
              b = c;
              Console.WriteLine("the numbers after swapping are {0},{1} ", a, b);

            int a, b;
            Console.Write("enter a and b values to swap ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the numbers before swapping are {0},{1} ", a, b);
          /*  a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("the numbers after swapping are {0},{1} ", a, b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("the numbers after swapping are {0},{1} ", a, b);*/
            int num;
            Console.Write("enter a number ");
            num = Convert.ToInt32(Console.ReadLine());
            for(int count1=1;count1<=num;count1++)
            {
                for (int count2 = 1; count2 <= count1; count2++)
                    Console.Write(count2);
                Console.WriteLine();
            }
        }
    }
}
