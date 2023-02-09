using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces
{
    internal class Dog : Animal, IAnimal
    {
        public string Name
        {
            get { return base._name; }
        }
        public string Color
        {
            get { return base._color; }
        }
        public float Height
        {
            get { return base._height; }
        }
        public int Age
        {
            get { return base._age; }
        }


        public Dog(string name, string color = "unknow", int age = 1, float height = 10f) : base(name, color, age, height) { }

        public string Cry()
        {
            return "Woof!";
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }
}
