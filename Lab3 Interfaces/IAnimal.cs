using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces
{
    internal interface IAnimal
    {
        string Name { get; }
        string Color { get; }
        float Height { get; }
        int Age { get; }

        void Eat();
        string Cry();

    }
}
