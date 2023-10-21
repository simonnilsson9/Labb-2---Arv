using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Lion : Animals
    {
        public string Gender;
        public Lion(int age, double weight, string name, string species, string colour, string gender) : base(age, weight, name, species, colour)
        {
            Gender = gender;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Lejonet {Name} säger Rawr Rawr.");
        }
        public new void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"{Name} tillhör könet {Gender}.");
        }
        public override void WildAnimal()
        {
            Console.WriteLine($"¨Lejonet {Name} är ett vilt djur.");
        }
        public void Hungry()
        {
            Console.WriteLine("Lejonet är hungrigt.");
        }
    }
}
