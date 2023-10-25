using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Animals
    {
        public int Age;
        public double Weight;
        public string Name;
        public string Species;
        public string Colour;
        
        public Animals(int age = 0, double weight = 0, string name = "Okänt", string species = "Okänt", string colour = "Okänt")
        {            
            Age = age;
            Weight = weight;
            Name = name;
            Species = species;
            Colour = colour;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Djuret gör ett ljud.");
        }

        public void AnimalInfo()
        {
            Console.WriteLine($"{Name} är en {Species} som väger {Weight} kg. Den har åldern {Age} och färgen {Colour}");
        }

        public virtual void WildAnimal()
        {
            Console.WriteLine("Djuret är vilt eller tamt.");
        }


    }
}
