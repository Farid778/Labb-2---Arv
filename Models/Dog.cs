using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv.Models
{
    internal class Dog : Animal
    {

        public string Breed { get; set; } = "Unknown";
        public bool IsTrained { get; set; } = false;

        public Dog(string name, int age, double weight, string diet, string gender, string breed, bool isTrained)
            : base(name, age, weight, diet, gender)
        {
            Breed = breed;
            IsTrained = isTrained;
        }
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a Woof sound.");
        }
    }
}
