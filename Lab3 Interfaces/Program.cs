using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P2 2
            Dog dog = new Dog("Alan");
            dog.Eat();
            Console.WriteLine(dog.Cry());

            //P2 3
            Cat cat = new Cat("Ruby");
            cat.Eat();
            Console.WriteLine(cat.Cry());

            //P2 4
            Console.WriteLine("Please input name of dog 1:");
            Dog dog1 = new Dog(Console.ReadLine());
            Console.WriteLine($"Dog:{dog1.Name}, color is {dog1.Color}, age is {dog1.Age}, height is {dog1.Height}.");

            Console.WriteLine("Please input name of dog 2:");
            string dog2Name = Console.ReadLine();
            Console.WriteLine("Please input color of dog 2:");
            string dog2Color = Console.ReadLine();
            Console.WriteLine("Please input age of dog 2:");
            string dog2Age = Console.ReadLine();
            Console.WriteLine("Please input height of dog 2:");
            string dog2Height = Console.ReadLine();
            Dog dog2 = new Dog(dog2Name,dog2Color,int.Parse(dog2Age),float.Parse(dog2Height));
            Console.WriteLine($"Dog:{dog2.Name}, color is {dog2.Color}, age is {dog2.Age}, height is {dog2.Height}.");

            //P2 5
            Console.WriteLine("Please input name of cat 1:");
            Cat cat1 = new Cat(Console.ReadLine());
            Console.WriteLine($"Dog:{cat1.Name}, color is {cat1.Color}, age is {cat1.Age}, height is {cat1.Height}.");

            Console.WriteLine("Please input name of cat 2:");
            string cat2Name = Console.ReadLine();
            Console.WriteLine("Please input color of cat 2:");
            string cat2Color = Console.ReadLine();
            Console.WriteLine("Please input age of cat 2:");
            string cat2Age = Console.ReadLine();
            Console.WriteLine("Please input height of cat 2:");
            string cat2Height = Console.ReadLine();
            Cat cat2 = new Cat(cat2Name, cat2Color, int.Parse(cat2Age), float.Parse(cat2Height));
            Console.WriteLine($"Dog:{cat2.Name}, color is {cat2.Color}, age is {cat2.Age}, height is {cat2.Height}.");

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(cat1);
            animals.Add(cat2);

            foreach (IAnimal animal in animals)
            {
                // animal is Dog ? "Dog name is:" : "Cat name is:"
                if (animal is Dog)
                {
                    Console.WriteLine(animals.IndexOf(animal) + ". Dog name is:" + animal.Name);
                }
                else
                {
                    Console.WriteLine(animals.IndexOf(animal) + ". Cat name is:" + animal.Name);
                }
            }
        }
    }
}
