using System;
using System.Collections.Generic;

namespace SwissTournament
{
    public class Match : IMatch
    {
        public IList<IPlayer> Players { get; }
        public IPlayer Winner { get; }
    }
}
