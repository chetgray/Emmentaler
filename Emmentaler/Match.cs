using System;
using System.Collections.Generic;

namespace Emmentaler
{
    public class Match : IMatch
    {
        public IList<IPlayer> Players { get; }
        public IPlayer Winner { get; }
    }
}
