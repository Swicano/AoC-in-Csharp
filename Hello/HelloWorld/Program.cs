using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string echoLine = Console.ReadLine();
            float testNumber = 1.2f;
            Console.WriteLine($"You wrote: {echoLine } and testNumber is {testNumber }");
            Console.WriteLine("Input a new Number:");
            string inputLine = Console.ReadLine();
            testNumber = float.Parse(inputLine);
            System.Console.WriteLine($"you entered: {testNumber }");
            


        }
    }
}

