using System;

namespace SwissTournament
{
    public interface IPlayer : IIdentifiable
    {
        string Name { get; }
        int Seed { get; }
    }
}
