using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv.Models
{
    internal class Bulldog : Dog
    {
        public bool IsFriendly { get; set; } = true;
        public Bulldog(string name, int age, double weight, string diet, string gender, bool isTrained, bool isFriendly)
            : base(name, age, weight, diet, gender, "Bulldog", isTrained)
        {
            IsFriendly = isFriendly;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a Bark sound.");
        }
    }

    
}


