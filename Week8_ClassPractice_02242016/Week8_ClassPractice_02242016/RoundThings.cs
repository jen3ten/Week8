using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ClassPractice_02242016
{
    class RoundThings
    {
        private string name;
        private double radius;
        private string color;

        public RoundThings()
        {
            this.name = "basketball";
            this.radius = 8.5;
            this.color = "orange";
        }
        
        public RoundThings(string name)
        {
            this.name = name;
            this.radius = 8.5;
            this.color = "orange";
        }

        public RoundThings(string name, double radius)
        {
            this.name = name;
            this.radius = radius;
            this.color = "orange";
        }

        public double BounceHeight
        {
            get { return this.BounceHeight; }
            set { this.BounceHeight = value; }
        }
    }
}
