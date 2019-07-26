using System;
using EasyConsole;

namespace Emmentaler.Pages
{
    class NewPlayerPage : Page
    {
        Emmentaler emmentaler;

        public NewPlayerPage(EasyConsole.Program program)
            : base("Add Player", program)
        {
            emmentaler = program as Emmentaler;
        }

        public override void Display()
        {
            base.Display();

            var name = Input.ReadString("Player name: ");
            var seed = Input.ReadInt("Seed: ", 0, Int32.MaxValue);

            emmentaler.tournament.AddPlayer(new Player() { Name = name, Seed = seed });

            Program.NavigateBack();
        }
    }
}
