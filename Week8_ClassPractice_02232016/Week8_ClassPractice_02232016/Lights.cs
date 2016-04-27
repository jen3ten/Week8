using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ClassPractice_02232016
{
    class Lights
    {
        private int lumens;
        public int wattage;
        public string manufacturer;
        public int stock;
        public bool on;

        public void FlipSwitch()
        {
            if (on)
                on = false;
            else
                on = true;
        }
    }
}
