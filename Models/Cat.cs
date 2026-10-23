using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv.Models
{
    internal class Cat : Animal
    {
        public bool IsIndoor { get; set; } = true;

        public Cat(string name, int age, double weight, string diet, string gender, bool isIndoor)
            : base(name, age, weight, diet, gender)
        {
            IsIndoor = isIndoor;
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purring.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a Meow sound.");
        }
    }
}
