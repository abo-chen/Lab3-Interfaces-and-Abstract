using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Alan", "yellow", 3);
            dog.Eat();

            //Animal cat = new Cat("Ruby", "white", 1);
            Cat cat = new Cat("Ruby", "white", 1);
            cat.Eat();
        }
    }
}
