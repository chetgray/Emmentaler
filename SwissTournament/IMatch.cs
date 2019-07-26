using System;
using System.Collections.Generic;

namespace SwissTournament
{
    public interface IMatch
    {
        IList<IPlayer> Players { get; }
        IPlayer Winner { get; }
    }
}
