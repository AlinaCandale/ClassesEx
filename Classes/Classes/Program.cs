using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();

            Dog myDog = new Dog("Grivei", "Maricica");
            Dog yourDog = new Dog("Lala", "Ion");

            //myDog._name = "Azorel";
            //myDog._birthDate = DateTime.Now.AddDays(100);
            decimal piDog = Dog.PI;

            Console.WriteLine(Dog.nrOfInstances);
            Console.WriteLine(Dog.GetTotalInstancesCreated());
        }
    }
}
