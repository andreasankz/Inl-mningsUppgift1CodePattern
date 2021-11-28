using System;

namespace InlämningsUppgift1CodePattern.Menu
{
    public interface IMenuFactory
    {
        void CreateMenu(string welcomeText);

        void CreateMenuChoices(int selector, string name, Action runThis);

        void ShowMenu();

        IMenu GetMenu();
    }
}
