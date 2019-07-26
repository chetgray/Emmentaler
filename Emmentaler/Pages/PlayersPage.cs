using System;
using EasyConsole;

namespace Emmentaler.Pages
{
    class PlayersPage : Page
    {
        Emmentaler emmentaler;

        public PlayersPage(EasyConsole.Program program)
            : base("Players", program)
        {
            emmentaler = program as Emmentaler;
        }

        public override void Display()
        {
            var menu = new Menu()
                .Add("Load player list", () => Program.NavigateTo<LoadPlayersPage>())
                .Add("Save player list", () => Program.NavigateTo<SavePlayersPage>())
                .Add("Add a player", () => Program.NavigateTo<NewPlayerPage>())
                .Add("Edit a player", () => Program.NavigateTo<EditPlayerPage>())
                .Add("Remove a player", () => Program.NavigateTo<RemovePlayerPage>())
                .Add("Go back", () => Program.NavigateBack());

            base.Display();

            foreach (var player in emmentaler.tournament.Players)
            {
                Output.WriteLine(player.ToString());
            }

            Console.WriteLine("---");
            menu.Display();
        }
    }
}
