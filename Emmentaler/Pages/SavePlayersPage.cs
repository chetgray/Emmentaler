using EasyConsole;
using System.IO;

namespace Emmentaler.Pages
{
    class SavePlayersPage : Page
    {
        Emmentaler emmentaler;

        public SavePlayersPage(EasyConsole.Program program)
            : base("Save List", program)
        {
            emmentaler = program as Emmentaler;
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Saving player list...");
            emmentaler.SavePlayersFile();
            Output.WriteLine("Saved.");
            Input.ReadString("Press [Enter] to continue");
            Program.NavigateBack();
        }
    }
}
