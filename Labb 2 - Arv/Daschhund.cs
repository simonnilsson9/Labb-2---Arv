using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Daschhund : Dog
    {
        public string FavouriteToy;
        public Daschhund(int age = 0, double weight = 0, string name = "Okänt", string species = "Okänt", string colour = "Okänt", string breed = "Okänt", string favouriteToy = "Okänt") : base(age, weight, name, species, colour, breed)
        {
            FavouriteToy = favouriteToy;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Taxen {Name} säger voff voff.");
        }
        public void GoForWalk(int minutes)
        {
            Console.WriteLine($"Taxen {Name} gick på en promenad i {minutes} minuter.");
        }
    }
}
