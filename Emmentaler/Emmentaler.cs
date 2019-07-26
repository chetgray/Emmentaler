using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using EasyConsole;
using Emmentaler.Pages;

namespace Emmentaler
{
    class Emmentaler : Program
    {
        public Tournament tournament = new Tournament();
        const string playerFilename = "players.json";

        static void Main()
        {
            new Emmentaler().Run();
        }

        public Emmentaler()
            : base("EMMENTALER Tournament Organizer", breadcrumbHeader: true)
        {
            AddPage(new MainPage(this));
            AddPage(new PlayersPage(this));
            AddPage(new LoadPlayersPage(this));
            AddPage(new SavePlayersPage(this));
            AddPage(new NewPlayerPage(this));
            AddPage(new EditPlayerPage(this));
            AddPage(new RemovePlayerPage(this));
            AddPage(new NotImplementedPage(this));

            SetPage<MainPage>();
        }

        public void LoadPlayersFile()
        {
            using (var file = File.OpenText(playerFilename))
            {
                var serializer = new JsonSerializer();
                var players = (List<Player>)serializer.Deserialize(file, typeof(List<Player>));

                foreach (var player in players)
                {
                    tournament.AddPlayer(player);
                }
            }
        }

        public void SavePlayersFile()
        {
            using (var writer = new StreamWriter(playerFilename))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(writer, tournament.Players);
            }
        }
    }
}
