using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces
{
    internal class Cat : Animal, IAnimal
    {
        public string Name
        {
            get { return base._name; }
        }
        public string Color
        {
            get { return base._color; }
        }
        // string IAnimal.Color { get { return base._color; } } only avalible in IAnimal
        public float Height
        {
            get { return base._height; }
        }
        public int Age
        {
            get { return base._age; }
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public string Cry()
        {
            return "Meow!";
        }

        public Cat(string name, string color = "unknow", int age = 1, float height = 10f) : base(name, color, age, height) { }
    }
}
