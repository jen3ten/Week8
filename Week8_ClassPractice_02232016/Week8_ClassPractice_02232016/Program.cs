using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ClassPractice_02232016
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair office = new Chair();
            office.weight = 43.7;
            string liftIt = office.AssessWeight();
            Console.WriteLine(liftIt);

            Animal animal = new Animal();
            animal.name = "Gerry";
            animal.legs = 4;
            animal.type = "sheep";
            Console.WriteLine("I am a {0}", animal.type);
            animal.MakeSound();

            animal.type = "llama";
            Console.WriteLine("I am a {0}", animal.type);
            animal.MakeSound();

            Lights lamp = new Lights();
            lamp.on = true;
            if (lamp.on)
                Console.WriteLine("The light is on");
            else
                Console.WriteLine("The light is off");

            Console.WriteLine("I am going to flip the switch");
            lamp.FlipSwitch();
            if (lamp.on)
                Console.WriteLine("The light is on");
            else
                Console.WriteLine("The light is off");



        }
    }

}
