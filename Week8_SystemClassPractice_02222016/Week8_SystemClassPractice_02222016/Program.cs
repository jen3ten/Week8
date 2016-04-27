using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_SystemClassPractice_02222016
{
    class Program
    { 
        static void Main(string[] args)
        {
            //string string1 = "Hello, World!";
            //bool answer;
            //answer = string1.EndsWith("World!");
            //Console.WriteLine("Ends With is: " + answer);

            //string string2 = null;
            //answer = String.IsNullOrEmpty(string2);
            //Console.WriteLine("Is Null or Empty is: "+ answer);
            //answer = string.IsNullOrEmpty(string1);
            //Console.WriteLine("Is Null or Empty is: " + answer);

            ////Ask user for a web address starting with www.
            ////Check to make sure the input starts with www.

            //Console.WriteLine("Enter a web page starting with www: ");
            //string webpage = Console.ReadLine();
            //if (webpage.StartsWith("www"))
            //{
            //    Console.WriteLine("Thanks!");
            //}
            //else
            //{
            //    Console.WriteLine("Please start with www..");
            //}

            //Console.WriteLine("Enter a web page: ");
            //string input = Console.ReadLine();
            //if (input.StartsWith("www"))
            //{
            //    Console.WriteLine("Thanks!");
            //}
            //else
            //{
            //    Console.WriteLine("That's not a web page");
            //}

            //Random randomThing = new Random();
            //for (int i = 0; i < 6; i++)
            //{
            //    int roll = randomThing.Next(10, 100);
            //    Console.WriteLine(roll);
            //}

            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int randomNum = random.Next(100, 201);
            //    Console.WriteLine(randomNum);
            //}

            //DateTime day = new DateTime();
            //Console.WriteLine(day.DayOfWeek);

            double area = (7 * 4) / 2;
            Console.WriteLine(area);

            double angleDegrees = 37;
            double angleRadian = angleDegrees * Math.PI / 180;
            double side1 = 24;
            double side2 = 32;
            double area2 = (side1 * side2 * Math.Sin(angleRadian)) / 2;
            Console.WriteLine(area2);

            
        }
    }
}
