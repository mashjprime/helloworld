using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Experiments();

            Person person2 = new Person();
            person2.FirstName = "Bob";
            person2.LastName = "The man";

            if(person2.FullName == "Bob Jungalist The man")
            {
                Console.WriteLine("Yeeewww");

            }
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
        }
    }
}
