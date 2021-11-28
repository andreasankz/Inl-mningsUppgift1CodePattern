using System;

namespace InlämningsUppgift1CodePattern.Menu
{
    public class MenuChoices : IMenuChoices
    {
        public MenuChoices(string name, Action runThis, int selector)
        {
            Name = name;
            RunThis = runThis;
            Selector = selector;
        }

        public string Name { get; set; }
        public Action RunThis { get; set; }
        public int Selector { get; set; }
    }
}
