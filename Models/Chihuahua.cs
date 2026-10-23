using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv.Models
{
    internal class Chihuahua : Dog
    {
        public bool IsSmall { get; set; } = true;
        public Chihuahua(string name, int age, double weight, string diet, string gender, bool isTrained, bool isSmall)
            : base(name, age, weight, diet, gender, "Chihuahua", isTrained)
        {
            IsSmall = isSmall;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a Yip sound.");
        }
    }
}
