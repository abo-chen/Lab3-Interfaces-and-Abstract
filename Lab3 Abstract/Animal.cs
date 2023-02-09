using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract
{
    internal abstract class Animal
    {
        private string _name;
        private string _color;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public abstract void Eat();

        public Animal(string name, string color, int age)
        {
            this._name = name;
            this._color = color;
            this._age = age;
        }
    }
}
