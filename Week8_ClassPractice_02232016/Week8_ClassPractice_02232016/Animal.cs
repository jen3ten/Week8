using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ClassPractice_02232016
{
    class Animal
    {
        public int legs;
        public string color;
        public string name;
        public string type;

        public void MakeSound()
        {
            switch(type)
            {
                case "pig": Console.WriteLine("Oink"); return;
                case "dog": Console.WriteLine("Woof"); return;
                case "sheep": Console.WriteLine("Baaaa"); return;
                default: Console.WriteLine("hmmmmm..."); return;
            }
        }
    }
}
