using InlämningsUppgift1CodePattern.Kennel;

namespace InlämningsUppgift1CodePattern
{
    public class Application : IApplication
    {
        private IMainMenu MainMenu;


        public Application(IMainMenu mainMenu)
        {
            MainMenu = mainMenu;

        }

        public void Run()
        {

            MainMenu.InitMenu();

            MainMenu.GetUserChoice();

        }
    }
}
