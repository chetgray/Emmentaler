using System;
using System.Collections.Generic;

namespace SwissTournament
{
    public class Round : IRound
    {
        public IList<IMatch> Matches { get; }
    }
}
