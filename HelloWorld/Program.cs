using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Experiments();

            // If statements are the same
            Console.WriteLine("Please enter your age:");
            int age = 18; //Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your password:");
            string password = "password";
            if (age >= 18 && password == "password")
                {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Security Lockdown");
            }
            // Switch Statement
            string name = "Steve";
            switch(name)
            {
                case "Steve":
                    Console.WriteLine($"Sup {name}");
                    break;
                case "Geoff":
                    Console.WriteLine("Howdy");
                    break;
                default:
                    Console.WriteLine("Hi");
                    break;
            }
            // Forgot what this is called....
            bool correct = true;
            int points = correct ? 10 : 0;
            Console.WriteLine(points);

            // Single line
            if (name == "Steve") Console.WriteLine("This is a single line if statement!");
            

        }

        static void Experiments()
        {
            Console.WriteLine("Hello World!");
            int[] a = { -5, 2, 123, 56, (int)3.5 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("Hey, would you like a \ttab??");
            String splitMe = "These,values,are,comma,separated";
            string[] intoArray = splitMe.Split(',');
            int j = 0;
            while (j < intoArray.Length)
            {
                Console.Write(intoArray[j] + " ");
                j++;
            }

            Person person = new Person();
            person.FirstName = "Mash";
            person.LastName = "Prime";

            Console.WriteLine("\n" + person.GetFullName());
            Console.WriteLine(person.FullName);

            Person person2 = new Person();
            person2.FirstName = "Bob";
            person2.LastName = "The man";

            if (person2.FullName == "Bob Jungalist The man")
            {
                Console.WriteLine("Yeeewww");

            }
        }
    }
}
