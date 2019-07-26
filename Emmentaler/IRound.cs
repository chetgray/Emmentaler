using System;
using System.Collections.Generic;

namespace Emmentaler
{
    public interface IRound
    {
        IList<IMatch> Matches { get; }
    }
}
