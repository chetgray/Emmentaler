using System;
using EasyConsole;

namespace Emmentaler.Pages
{
    class RemovePlayerPage : Page
    {
        Emmentaler emmentaler;

        public RemovePlayerPage(EasyConsole.Program program)
            : base("Remove Player", program)
        {
            emmentaler = program as Emmentaler;
        }

        public override void Display()
        {
            var menu = new Menu();

            base.Display();

            Output.WriteLine("Select a player to remove:");

            foreach (var player in emmentaler.tournament.Players)
            {
                menu.Add(player.ToString(), () => emmentaler.tournament.Players.Remove(player));
            }

            menu.Add("Go back", () => Program.NavigateBack());
            menu.Display();

            Program.NavigateBack();
        }
    }
}
