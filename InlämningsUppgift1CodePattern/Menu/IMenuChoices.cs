using System;

namespace InlämningsUppgift1CodePattern.Menu
{
    public interface IMenuChoices
    {
        string Name { get; set; }
        Action RunThis { get; set; }
        int Selector { get; set; }
    }
}
