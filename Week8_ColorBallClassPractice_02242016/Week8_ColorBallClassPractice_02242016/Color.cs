using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ColorBallClassPractice_02242016
{
    class Color
    {
        public int red;
        public int green;
        public int blue;
        public int alpha;

        public Color (int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color (int red, int green, int blue)
        {
            this.alpha = 255;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public void GetValues ()
        {
            Console.WriteLine("Red is: {0}", this.red);
            Console.WriteLine("Green is: {0}", this.green);
            Console.WriteLine("Blue is: {0}", this.blue);
            Console.WriteLine("Alpha is: {0}", this.alpha);
        }

        public void SetValues (int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
            Console.WriteLine("Red is: {0}", this.red);
            Console.WriteLine("Green is: {0}", this.green);
            Console.WriteLine("Blue is: {0}", this.blue);
            Console.WriteLine("Alpha is: {0}", this.alpha);
        }

        public void SetUserValues ()
        {
            Console.WriteLine("What is red? ");
            this.red = int.Parse(Console.ReadLine());
            Console.WriteLine("What is green? ");
            this.green = int.Parse(Console.ReadLine());
            Console.WriteLine("What is blue? ");
            this.blue = int.Parse(Console.ReadLine());
            Console.WriteLine("What is alpha? ");
            this.alpha = int.Parse(Console.ReadLine());

            Console.WriteLine("Red is: {0}", this.red);
            Console.WriteLine("Green is: {0}", this.green);
            Console.WriteLine("Blue is: {0}", this.blue);
            Console.WriteLine("Alpha is: {0}", this.alpha);

        }

        public void GrayScale(int red, int green, int blue)
        {
            double gray = (Convert.ToDouble(red + green + blue) )/ 3;
            Console.WriteLine("Gray scale is: {0:f4}", gray);
        }

    }
}
