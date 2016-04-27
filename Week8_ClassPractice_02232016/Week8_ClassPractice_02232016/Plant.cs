using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ClassPractice_02232016
{
    class Plant                         //The new class called "Plant"
    {
        public double height = 6.54;           //Some fields
        public string color = "green";
        public int number;
        public string[] names;
        
        private double ConvertHeight(double inches)     //A method example with a modifier, return type, method name, ()
        {                                               //...parameter list, and return statement
            double cm = inches * 2.54;
            return cm;
        }

        public bool IsGreen(string color)              //Another method example with all the same elements
        {
            if (color.ToLower() == "green")
                return true;
            else
                return false;
        }

    }
}
