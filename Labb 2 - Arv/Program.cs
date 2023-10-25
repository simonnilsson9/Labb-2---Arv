namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog = new Dog(12,10.3,"Simon","hund","brun","rottweiler");
            Cat cat = new Cat(5, 5.6, "Emm", "katt", "grå", "Emmsan");
            Lion lion = new Lion(25, 256, "Simba", "lejon", "gul", "man");
            Daschhund daschhund = new Daschhund(7,10,"Max","hund","vit","tax","tuggleksak");
            Labrador labrador = new Labrador(2,4,"Ozzy","hund","beige","labrador","hane");


            dog.MakeSound();
            cat.MakeSound();
            lion.MakeSound();            
            labrador.MakeSound();
            daschhund.MakeSound();


        }
    }
}