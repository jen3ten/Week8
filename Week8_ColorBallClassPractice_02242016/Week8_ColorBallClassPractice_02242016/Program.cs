using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ColorBallClassPractice_02242016
{
    class Program
    {
        static void Main(string[] args)
        {
            Color someColor = new Color(25, 25, 25, 25);
            someColor.GetValues();
            someColor.GrayScale(someColor.red, someColor.green, someColor.blue);

            Console.WriteLine();
            someColor.SetValues(20, 20, 20, 20);
            someColor.GrayScale(someColor.red, someColor.green, someColor.blue);

            Console.WriteLine();
            someColor.SetUserValues();
            someColor.GrayScale(someColor.red, someColor.green, someColor.blue);

        }
    }
}
