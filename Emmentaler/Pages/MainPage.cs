using EasyConsole;

namespace Emmentaler.Pages
{
    class MainPage : MenuPage
    {
        public MainPage(EasyConsole.Program program)
            : base("Emmentaler", program,
                new Option("Manage Players", () => program.NavigateTo<PlayersPage>()),
                new Option("Schedule Matches", () => program.NavigateTo<NotImplementedPage>()),
                new Option("Quit", () => {}))
        {
        }
    }
}
