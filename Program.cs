using System;

namespace Laba_6_V_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(name: "Kola",countVaccination:0,breed:"mops",isHaveOwner:false );
            Lion lion1 = new Lion(name: "Afia",countHerdingPerDay:10,habitat:"Asia",isInTheRedBook:true);
            Snake snake1 = new Snake(name: "Venera",bodyLength:33,isHavePoison:true,isCaught:true);

            Animals animals = new Animals(dog1, lion1);
            Console.WriteLine("\nAnimals:\n" + animals);
            animals.Add(snake1);
            Console.WriteLine("\nAnimals:\n" + animals);
            animals.RemoveByIndex(1);
            Console.WriteLine("\nAnimals:\n" + animals);
            animals.UpdateByIndex(snake1, 0);
            Console.WriteLine("\nAnimals:\n" + animals);
            Console.WriteLine("snake1.Eat()");
            snake1.Eat();
            Console.WriteLine("\nArray:\n" + animals);
        }
    }
}
