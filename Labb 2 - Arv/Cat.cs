﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Cat : Animals
    {
        public string NickName;

        public Cat(int age = 0, double weight = 0, string name = "Okänt", string species = "Okänt", string colour = "Okänt", string nickname = "Okänt"): base(age,weight,name,species,colour)
        {
            NickName = nickname;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Katten {Name} säger mjau mjau.");
        }
        public new void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"{Name} har smeknamnet {NickName}.");
        }
        public override void WildAnimal()
        {
            Console.WriteLine($"Katten {Name} är tam.");
        }
        public void IsAnimalPlayful()
        {
            Console.WriteLine($"Katten {Name} är lekfull.");
        }
    }
}
