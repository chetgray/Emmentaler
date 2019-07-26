using System;
using System.Collections.Generic;

namespace SwissTournament
{
    public class Tournament
    {
        public IList<IPlayer> Players { get; } = new List<IPlayer>();
        public IList<IRound> Rounds { get; }
        public int? CurrentRoundNumber { get; }

        public bool TryAddPlayer(IPlayer player)
        {
            Players.Add(player);
            return true;
        }
    }
}
