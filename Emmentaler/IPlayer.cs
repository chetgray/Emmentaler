using System;

namespace Emmentaler
{
    public interface IPlayer : IIdentifiable
    {
        string Name { get; set; }
        int Seed { get; set; }
    }
}
