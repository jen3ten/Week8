using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ClassPractice_02232016
{
    class Chair
    {
        public bool arms;
        public int numLegs;
        public string legStyle;
        public double weight;

        public void Assemble()
        {
            Console.WriteLine("I assembled the chair!");
        }

        public string AssessWeight()
        {
            if (weight >= 40)
            {
                return "Too heavy to lift";
            }
            return "You can lift it";
        }
  
    }
}
