using EasyConsole;
using System.IO;

namespace Emmentaler.Pages
{
    class LoadPlayersPage : Page
    {
        Emmentaler emmentaler;

        public LoadPlayersPage(EasyConsole.Program program)
            : base("Load List", program)
        {
            emmentaler = program as Emmentaler;
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Loading player list...");
            try
            {
                emmentaler.LoadPlayersFile();
            }
            catch (FileNotFoundException e)
            {
                Output.WriteLine(e.Message);
                Input.ReadString("Press [Enter] to continue");
                Program.NavigateBack();
            }
            Output.WriteLine("Loaded.");
            Input.ReadString("Press [Enter] to continue");
            Program.NavigateBack();
        }
    }
}
