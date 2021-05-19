using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTraining_Continue.AnotherExample
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Dog(),new Cat()
            };
            foreach(Animal i in animals)
            {
                i.name();
                i.type();
            }
        }
    }
}
