using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract
{
    internal class Dog : Animal
    {
        public Dog(string name, string color, int age) : base(name, color, age) { }

        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }
}
