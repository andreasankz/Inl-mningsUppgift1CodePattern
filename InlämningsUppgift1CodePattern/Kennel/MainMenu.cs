using InlämningsUppgift1CodePattern.Animal;
using InlämningsUppgift1CodePattern.Customer;
using InlämningsUppgift1CodePattern.Menu;
using System;

namespace InlämningsUppgift1CodePattern.Kennel
{
    public class MainMenu : IMainMenu
    {
        private IMenuFactory MenuFactory;
        private ICustomerFactory CustomerFactory;
        private IAnimalFactory AnimalFactory;



        public MainMenu(IMenuFactory menuFactory, ICustomerFactory customerFactory, IAnimalFactory animalFactory)
        {
            MenuFactory = menuFactory;
            CustomerFactory = customerFactory;
            AnimalFactory = animalFactory;
        }

        public void GetUserChoice()
        {
            while (true)
            {
                var userInput = Console.ReadKey(true);

                foreach (var menuItem in MenuFactory.GetMenu().MenuChoices)
                {
                    if (menuItem.Selector.ToString() == userInput.KeyChar.ToString())
                    {
                        Console.Clear();
                        MenuFactory.ShowMenu();
                        menuItem.RunThis();
                    }
                    else if (userInput.KeyChar == 'c')
                    {
                        Environment.Exit(0);

                    }
                }
            }
        }

        public void InitMenu()
        {
            MenuFactory.CreateMenu("Welcome to KennelApp");
            MenuFactory.CreateMenuChoices(1, "Registrate new Customers", CustomerFactory.RegisterCustomer);
            MenuFactory.CreateMenuChoices(2, "Registrate new Dog", AnimalFactory.RegisterDog);
            MenuFactory.CreateMenuChoices(3, "List all the Customers", CustomerFactory.ListAllCustomers);
            MenuFactory.CreateMenuChoices(4, "List all the Dogs", AnimalFactory.ListAllDogs);
            //MenuFactory.CreateMenuChoices(5, "Wich dog belongs to wich Customer", );
            //MenuFactory.CreateMenuChoices(6, "Check in a Dog", );
            //MenuFactory.CreateMenuChoices(7, "Check out a Dog", );
            MenuFactory.ShowMenu();

        }


    }
}
