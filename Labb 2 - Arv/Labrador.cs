using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Labrador : Dog
    {
        public string Gender;
        public Labrador(int age = 0, double weight = 0, string name = "Okänt", string species = "Okänt", string colour = "Okänt", string breed = "Okänt", string gender = "Okänt"): base(age, weight, name, species, colour, breed) 
        { 
            Gender = gender;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Labradoren {Name} säger voff voff.");
        }
        public void MakeTrick()
        {
            Console.WriteLine($"Labradoren {Name} gör ett trick!");
        }

    }
}
