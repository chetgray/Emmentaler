using System;
using System.Collections.Generic;

namespace SwissTournament
{
    public class Tournament
    {
        public IList<IPlayer> Players { get; }
        public IList<IRound> Rounds { get; }
        public int? CurrentRoundNumber { get; }
    }
}
