using System;

namespace SwissTournament
{
    public class Player : IPlayer
    {
        public Guid Id { get; }
        public string Name { get; }
        public int Seed { get; }

        public Player()
        {
            Id =  Guid.NewGuid();
        }

        public Player(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
