# Swiss-System Tournament Scheduler

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
  - int Number
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
