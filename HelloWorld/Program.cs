using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my first C# application ;)");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"You are awesome {name}");
        }
    }
}
