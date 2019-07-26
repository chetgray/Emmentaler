using System;

namespace SwissTournament
{
    public interface IPlayer
    {
        Guid Id { get; }
        string Name { get; }
        int Seed { get; }
    }
}
