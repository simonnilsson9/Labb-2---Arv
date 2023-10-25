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
        
        public Dog(int age = 0, double weight = 0, string name = "Okänt", string species = "Okänt", string colour = "Okänt", string breed = "Okänt"): base(age, weight, name, species, colour)
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
            Console.WriteLine($"Hunden {Name} mår bra.");
        }
    }
}
