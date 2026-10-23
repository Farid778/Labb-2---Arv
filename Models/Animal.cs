using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv.Models
{
    internal class Animal
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public double Weight { get; set; } = 0.0;
        public string Diet { get; set; } = "Unknown";
        public string Gender { get; set; } = "Unknown";

        public Animal(string name, int age, double weight, string diet, string gender)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Diet = diet;
            Gender = gender;
        }




        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} is making a sound.");
        }

    }
}
