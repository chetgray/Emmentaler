# Emmentaler

**Swiss-System Tournament Organizer**

## Code Louisville

Though the actual match scheduling functionality is not implemented, the
player management _is_. Players can be created, edited, and deleted, and
player lists can be loaded and saved. Emmentaler targets .NET Core 2.2,
but should run on .NET Framework just as well. To try it out, enter the
`Emmentaler` project directory and `dotnet run` from the console.

## Object Model

- Tournament
  - int Seed
  - Player[] Players
  - Round[] Rounds
  - int? CurrentRoundNumber
- Player
  - Guid Id
  - string Name
  - int Seed
- Round
  - Match[] Matches
- Match
  - Player[] Players
  - Player Winner

## TODO

- dropping players
- multi-game matches
- multi-player games/matches
- draw games/matches
- configure game/match points
- scheduling systems
  - Amalfi
  - accelerated
  - avoid repeat pairings
