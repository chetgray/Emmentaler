using System;

namespace SwissTournament
{
    public class Player : IPlayer
    {
        public Guid Id { get; }
        public string Name { get; } = "";
        public int Seed { get; } = 0;

        public Player()
        {
            Id =  Guid.NewGuid();
        }

        public Player(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} (seed: {Seed})";
        }
    }
}
