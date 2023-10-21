using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Dog : Animals
    {
        public string Breed;

        public Dog(int age, double weight, string name, string species, string colour, string breed): base(age, weight, name, species, colour)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Hunden {Name} säger voff voff.");
        }
        public new void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"{Name} tillhör rasen {Breed}.");
        }
        public override void WildAnimal()
        {
            Console.WriteLine($"Hunden {Name} är tam.");
        }
        public void AnimalFeelings()
        {
            Console.WriteLine("Djuret mår bra.");
        }
    }
}
