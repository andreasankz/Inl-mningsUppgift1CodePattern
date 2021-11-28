using System.Collections.Generic;

namespace InlämningsUppgift1CodePattern.Menu
{
    public class Menu : IMenu
    {
        public string WelcomeText { get; set; }
        public List<IMenuChoices> MenuChoices { get; set; }
    }
}
