namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog = new Dog(12,10.3,"Simon","Hund","brun","Tax");
            Cat cat = new Cat(5, 5.6, "Emm", "Katt", "grå", "Emmsan");
            Lion lion = new Lion(25, 256, "Simba", "Lejon", "gul", "man");
            
            cat.MakeSound(); lion.MakeSound(); dog.MakeSound();
            
            
        }
    }
}