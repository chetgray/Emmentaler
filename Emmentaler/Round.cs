using System;
using System.Collections.Generic;

namespace Emmentaler
{
    public class Round : IRound
    {
        public IList<IMatch> Matches { get; }
    }
}
