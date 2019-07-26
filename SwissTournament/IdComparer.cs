using System;
using System.Collections.Generic;

namespace SwissTournament
{
    public class IdComparer : EqualityComparer<IIdentifiable>
    {
        public override bool Equals(IIdentifiable x, IIdentifiable y)
        {
            return x.Id == y.Id;
        }

        public override int GetHashCode(IIdentifiable obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
