using System;
using EasyConsole;

namespace Emmentaler.Pages
{
    class NotImplementedPage : Page
    {
        public NotImplementedPage(EasyConsole.Program program)
            : base("", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("This functionality is not yet implemented.");
            Input.ReadString("Press [Enter] to go back");
            Program.NavigateBack();
        }
    }
}
