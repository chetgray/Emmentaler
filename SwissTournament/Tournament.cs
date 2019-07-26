using System;
using System.Collections.Generic;

namespace SwissTournament
{
    public class Tournament
    {
        public IList<IPlayer> Players { get; } = new List<IPlayer>();
        public IList<IRound> Rounds { get; }
        public int? CurrentRoundNumber { get; }

        public bool AddPlayer(IPlayer player)
        {
            if (Players.Contains(player))
            {
                return false;
            }
            else
            {
                Players.Add(player);
                return true;
            }
        }
    }
}
