using System;
using Xunit;
using FluentAssertions;

namespace SwissTournament.Tests
{
    public class Tournament_TryAddPlayer
    {
        Tournament tournament = new Tournament();

        [Fact]
        public void AddsPlayer()
        {
            //Given
            var player = new FakePlayer();

            //When
            tournament.TryAddPlayer(player);

            //Then
            tournament.Players.Should().Contain(player);
        }
    }
}
