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
            Animal misteryAnimal= new Animal();

            misteryAnimal.EchoAnimalSound(0);
            misteryAnimal.EchoAnimalSound(1);
            misteryAnimal.EchoAnimalSound(2);
            misteryAnimal.EchoAnimalSound(3);
            misteryAnimal.EchoAnimalSound(4);

            Console.Read();
        }
    }
}
