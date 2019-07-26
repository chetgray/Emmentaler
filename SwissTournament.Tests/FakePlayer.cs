using System;

namespace SwissTournament.Tests
{
    public class FakePlayer : IPlayer
    {
        public Guid Id
        {
            get => throw new NotImplementedException();
        }

        public string Name
        {
            get => throw new NotImplementedException();
        }

        public int Seed
        {
            get => throw new NotImplementedException();
        }
    }
}
