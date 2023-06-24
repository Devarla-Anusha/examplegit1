using System;
using System.Collections.Generic;
using System.Text;

namespace CABasicexamples
{
    class example8   //area of a triangle
    {
        static void Main()
        {
            double  height,baase, area;
            Console.WriteLine("enter base and height");
            height = Convert.ToDouble(Console.ReadLine());
            baase = Convert.ToDouble(Console.ReadLine());
            area = 0.5 * baase * height;
            Console.WriteLine("the area of traingle is " + area);
            

        }
    }
}
