using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ColorBallClassPractice_02242016
{
    class Ball
    {
        private double radius;
        private Color color;
        private int throws = 0;

        public Ball ()
        {
            this.radius = 20;
        }

        public void Pop()
        {
            this.radius = 0;
        }

        public void Throw()
        {
            if (this.radius > 0)
            {
                this.throws = this.throws + 1;
                Console.WriteLine("Good throw!");
            }
            else
            {
                Console.WriteLine("I can't throw the ball, it's popped!");
            }
        }

        public void NumThrows()
        {
            Console.WriteLine("Ball was thrown {0} times", this.throws);
        }
    }
}
