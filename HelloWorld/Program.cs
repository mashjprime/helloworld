using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Experiments();
            //shapes();     
            textFiles();    
                            
                            
        }                   

        static void textFiles()
        {
            // save the file path as a string variable
            string filePath = @"D:\code\c-sharp\HelloWorld\HelloWorld\data.txt";

            // create person object array
            List<Person> people = new List<Person>();
            // create text file line array
            List<string> lines = File.ReadAllLines(filePath).ToList();
            // split each word at the , and save it into an array
            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                // Create person object and populate the data
                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.MiddleName = entries[1];
                newPerson.LastName = entries[2];
                newPerson.Age = entries[3];
                newPerson.MoreInfo = entries[4];
                // Add person object to people array
                people.Add(newPerson);
            }
            // List all the objects in people array to console
            foreach (var person in people)
            {
                Console.WriteLine($" {person.FirstName} {person.MiddleName} {person.LastName}: {person.Age}");
                Console.WriteLine("\t^" + person.MoreInfo);
            }
            // Add a new person object to people array
            people.Add(new Person { FirstName = "Fish", MiddleName = "in", LastName = "tank", Age = "2", MoreInfo = "So purdy" });
            // Create new array for storing people data in a csv exportable format
            List<string> output = new List<string>();
            foreach (var person in people)
            {
                // This is the comma seperated format
                output.Add($"{person.FirstName},{person.MiddleName},{person.LastName},{person.Age},{person.MoreInfo}");
            }
            Console.WriteLine("Writing to file...");
            // Overwrite text file with new data
            File.WriteAllLines(filePath, output);

            Console.WriteLine("Complete");

                                          
            /*
            File.ReadAllLines(filePath);
            List<string> lines = File.ReadAllLines(filePath).ToList(); // Read from text file

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("Boss Tacular Prime, 7, Boss ahhaaa");

            File.WriteAllLines(filePath, lines); // Write to a text file*/
        }


        static void shapes()
        {
            int[] values = { 1, 6345, 234, 34, 756, 21 };
            Array.Sort(values);
            for (int x = 0; x < values.Length; x++)
            {
                Console.WriteLine(values[x]);
            }
            Array.Reverse(values);
            for (int x = 0; x < values.Length; x++)
            {
                Console.WriteLine(values[x]);
            }


            // Triangularism
            int i = 9;
            while (i >= 0)
            {
                int k = i;
                while (k >= 0)
                {
                    Console.Write(k + " ");
                    k--;
                }
                Console.WriteLine();
                i--;
            }
        }

        static void Experiments()
        {
            // Lists
            List<int> grades = new List<int>();
            grades.Add(5);
            grades.Add(10);


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
            switch (name)
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
    }
}
