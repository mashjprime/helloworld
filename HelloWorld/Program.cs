using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { -5, 2, 123, 56, (int)3.5 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("Hey, would you like a \ttab?");
            String splitMe = "These,values,are,comma,separated";
            string[] intoArray = splitMe.Split(',');
            int j = 0;
            while(j<intoArray.Length)
            {
                Console.Write(intoArray[j]+ " ");
                j++;
            }

        }
    }
}
