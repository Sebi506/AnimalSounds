using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Animal
    {
        private string[] animalList = { "cat", "dog", "fish", "owl", "pikachu"};
        private string[] animalsSound = { "meow", "ham", "...", "hoot", "pika" };

        public void EchoAnimalSound(int position)
        {
            Console.WriteLine("The " + animalList[position]+ " said "+ animalsSound[position]+" !");
        }
    }
}
