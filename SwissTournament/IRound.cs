using System;
using System.Collections.Generic;

namespace SwissTournament
{
    public interface IRound
    {
        IList<IMatch> Matches { get; }
    }
}
