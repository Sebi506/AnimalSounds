using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> AnimalList = new List<Animal>();

            Animal dog = new Animal("Dog");
            dog.AddSound("ham");
            AnimalList.Add(dog);

            Animal cat = new Animal("Cat");
            cat.AddSound("meow");
            AnimalList.Add(cat);

            Animal fish = new Animal("Fish");
            fish.AddSound("...");
            AnimalList.Add(fish);

            Animal owl = new Animal("Owl");
            owl.AddSound("hoot");
            AnimalList.Add(owl);

            Animal Pikachu = new Animal("Pikachu");
            Pikachu.AddSound("pika");
            AnimalList.Add(Pikachu);


            foreach (Animal a in AnimalList)
            {
                a.EchoAnimalSound(0);
            }
            Console.Read();
        }
    }
}
