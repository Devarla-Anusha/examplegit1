using System;
using System.Collections.Generic;
using System.Text;

namespace CABasicexamples
{
    class example1
    {
        static void Main(string[]args)
        {
            string Name;
            Console.WriteLine("enter any name ");
            Name = Console.ReadLine();
            Console.WriteLine("the entered name is " +Name);
            Console.WriteLine($"the entered name is {Name}");
        }
    }
}
