using System;

namespace SwissTournament
{
    public interface IPlayer : IIdentifiable
    {
        string Name { get; set; }
        int Seed { get; set; }
    }
}
