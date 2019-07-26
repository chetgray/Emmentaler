using System;
using System.Collections.Generic;
using System.Linq;

namespace Emmentaler
{
    public class Tournament
    {
        public IList<IPlayer> Players { get; } = new List<IPlayer>();
        public IList<IRound> Rounds { get; }
        public int? CurrentRoundNumber { get; }

        public bool AddPlayer(IPlayer player)
        {
            var players = Players as IList<IPlayer>;

            if (players.Contains(player, new IdComparer()))
            {
                return false;
            }
            else
            {
                players.Add(player);
                return true;
            }
        }
    }
}
