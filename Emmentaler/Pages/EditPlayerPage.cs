using System;
using EasyConsole;

namespace Emmentaler.Pages
{
    class EditPlayerPage : Page
    {
        Emmentaler emmentaler;
        Player selectedPlayer;

        public EditPlayerPage(EasyConsole.Program program)
            : base("Edit Player", program)
        {
            emmentaler = program as Emmentaler;
        }

        public override void Display()
        {
            var menu = new Menu();

            base.Display();

            Output.WriteLine("Select a player to edit:");

            foreach (var player in emmentaler.tournament.Players)
            {
                menu.Add(player.ToString(), () => selectedPlayer = player as Player);
            }

            menu.Add("Go back", () => Program.NavigateBack());
            menu.Display();

            Console.WriteLine("---");
            Output.WriteLine(selectedPlayer.ToString());

            selectedPlayer.Name = Input.ReadString("New name: ");
            selectedPlayer.Seed = Input.ReadInt("New seed: ", 0, Int32.MaxValue);

            Program.NavigateBack();
        }
    }
}
