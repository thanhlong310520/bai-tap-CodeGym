using System;

namespace Animal_va_IEdible
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }
            Console.WriteLine("---------------------------------------------------");
            Edible[] edibles = new Edible[3];
            edibles[0] = new Chicken();
            edibles[1] = new Apple();
            edibles[2] = new Orange();
            foreach(Edible edible in edibles)
            {
                Console.WriteLine(edible.HowtoEat());
            }
        }
    }
}
