using System;
using System.Collections.Generic;

namespace Emmentaler
{
    public interface IMatch
    {
        IList<IPlayer> Players { get; }
        IPlayer Winner { get; }
    }
}
