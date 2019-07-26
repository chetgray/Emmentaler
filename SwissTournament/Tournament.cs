using System;
using System.Collections.Generic;

namespace SwissTournament
{
    public class Tournament
    {
        public IReadOnlyList<IPlayer> Players { get; } = new List<IPlayer>();
        public IList<IRound> Rounds { get; }
        public int? CurrentRoundNumber { get; }

        public bool AddPlayer(IPlayer player)
        {
            var players = Players as IList<IPlayer>;

            if (players.Contains(player))
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
