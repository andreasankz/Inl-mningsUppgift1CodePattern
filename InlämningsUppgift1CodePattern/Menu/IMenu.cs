using System.Collections.Generic;

namespace InlämningsUppgift1CodePattern.Menu
{
    public interface IMenu
    {
        string WelcomeText { get; set; }
        List<IMenuChoices> MenuChoices { get; set; }
    }
}
