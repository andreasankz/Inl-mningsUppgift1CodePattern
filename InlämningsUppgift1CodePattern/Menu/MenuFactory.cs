using System;
using System.Collections.Generic;

namespace InlämningsUppgift1CodePattern.Menu
{
    public class MenuFactory : IMenuFactory
    {
        private IMenu Menu;
        private Func<int, string, Action, IMenuChoices> MenuChoicesFunc;

        public MenuFactory(IMenu menu, Func<int, string, Action, IMenuChoices> menuChoicesFunc)
        {
            Menu = menu;
            MenuChoicesFunc = menuChoicesFunc;
        }

        public void CreateMenu(string welcomeText)
        {
            Menu.WelcomeText = welcomeText;
            Menu.MenuChoices = new List<IMenuChoices>();
        }

        public void CreateMenuChoices(int selector, string name, Action runThis)
        {
            Menu.MenuChoices.Add(MenuChoicesFunc(selector, name, runThis));
        }

        public IMenu GetMenu()
        {
            return Menu;
        }

        public void ShowMenu()
        {
            Console.WriteLine(Menu.WelcomeText);
            Console.WriteLine("-----------------------");
            foreach (var menuChoices in Menu.MenuChoices)
            {
                Console.WriteLine(menuChoices.Selector + ": " + menuChoices.Name);
            }
        }
    }
}
