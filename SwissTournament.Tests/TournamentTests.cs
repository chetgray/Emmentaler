using System;
using Xunit;
using FluentAssertions;

namespace SwissTournament.Tests
{
    public class TournamentTests
    {
        Tournament tournament = new Tournament();

        [Fact]
        public void TryAddPlayer_EmptyTournament_AddsPlayer()
        {
            //Given
            var player = new FakePlayer();

            //When
            var wasAdded = tournament.TryAddPlayer(player);

            //Then
            wasAdded.Should().BeTrue();
            tournament.Players.Should().Contain(player);
        }

        [Fact]
        public void TryAddPlayer_PlayerAlreadyAdded_DisallowsDuplicate()
        {
            //Given
            var player = new FakePlayer();

            //When
            tournament.TryAddPlayer(player);
            var wasAddedAgain = tournament.TryAddPlayer(player);

            //Then
            wasAddedAgain.Should().BeFalse("because the player was already in the tournament");
            tournament.Players.Should().ContainSingle(p => p == player);
        }
    }
}
