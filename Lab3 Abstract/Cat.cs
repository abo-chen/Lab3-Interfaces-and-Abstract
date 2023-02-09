using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract
{
    internal class Cat:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public Cat(string name, string color, int age):base(name, color, age) { }
    }
}
