using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Animal
    {
        string AnimalName;
        List<String> AnimalSounds = new List<string>();

        public Animal() { }

        public Animal(string animalName)

        {
            this.AnimalName = animalName;

        }
        public Animal(string animalName, List<string> animalsounds)

        {
            this.AnimalName = animalName;
            this.AnimalSounds = animalsounds;

        }
        public string GetAnimalName() { return AnimalName; }
        public void SetAnimalName(string animalName) { this.AnimalName = animalName; }

        public void AddSound(string soundName)
        {
            AnimalSounds.Add(soundName);
        }

        public void RemoveSound(string soundName) { AnimalSounds.Remove(soundName); }

        public void EchoAnimalSound(int position)
        {
            Console.WriteLine("The " + AnimalName + " said " + AnimalSounds[position] + " !");
        }
    }
}
