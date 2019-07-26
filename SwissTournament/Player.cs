using System;

namespace SwissTournament
{
    public class Player : IPlayer
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public int Seed { get; set; } = 0;

        public override string ToString()
        {
            return $"{Name} (seed: {Seed})";
        }
    }
}
