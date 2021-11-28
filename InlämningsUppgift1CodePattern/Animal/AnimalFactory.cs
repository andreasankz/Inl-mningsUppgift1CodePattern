using InlämningsUppgift1CodePattern.Customer;
using System;
using System.Collections.Generic;

namespace InlämningsUppgift1CodePattern.Animal
{
    public class AnimalFactory : IAnimalFactory
    {
        public List<IDog> ListOfDogs { get; set; }
        private ICustomerFactory CustomerFactory;
        private IDog Dog;

        public AnimalFactory(ICustomerFactory customerFactory, IDog dog)
        {
            CustomerFactory = customerFactory;
            ListOfDogs = new List<IDog>();

            Dog = dog;
        }


        public void ListAllDogs()
        {
            Console.WriteLine("\n\nHere are all the registrated dogs: ");
            Console.WriteLine("--------------------------------------------");

            foreach (var Dog in ListOfDogs)
            {
                Console.WriteLine($"Name: {Dog.Name} Color: {Dog.Color} Age: {Dog.Age} Type: {Dog.TypeOfDog}");
            }
        }

        public void RegisterDog()
        {
            int age;
            string input;

            Console.WriteLine("\n\nEnter name of Dog: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter color: ");
            var color = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter age: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out age));
           
            Console.WriteLine("Enter type: ");
            var typeOfDog = Console.ReadLine();
            
            ListOfDogs.Add(new Dog { Name = name, Color = color, Age = age, TypeOfDog = typeOfDog });
            Console.WriteLine("Dog added! Choice another option above or press C to exit!");
        }
    }
}
