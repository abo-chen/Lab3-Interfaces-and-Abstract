using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces
{
    internal abstract class Animal
    {
        protected string _name;
        protected string _color;
        protected int _age;
        protected float _height;

        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
        //public string Color
        //{
        //    get { return _color; }
        //    set { _color = value; }
        //}
        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}

        //public abstract void Eat();

        public Animal(string name, string color, int age, float height)
        {
            this._name = name;
            this._color = color;
            this._age = age;
            this._height = height;
        }
    }
}
