using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv.Models
{
    internal class Horse : Animal
    {
        public bool IsRacingHorse { get; set; } = false;

        public Horse(string name, int age, double weight, string diet, string gender, bool isRacingHorse)
            : base(name, age, weight, diet, gender)
        {
            IsRacingHorse = isRacingHorse;
        }
        public void Jumping()
        {
            Console.WriteLine($"{Name} is jumping.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a Neigh sound.");
        }

    }
}
