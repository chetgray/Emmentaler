using System;
using Newtonsoft.Json;

namespace SwissTournament
{
    public class Player : IPlayer
    {
        [JsonProperty]
        public Guid Id { get; } = Guid.NewGuid();

        [JsonProperty]
        public string Name { get; set; } = "";

        [JsonProperty]
        public int Seed { get; set; } = 0;

        public override string ToString()
        {
            return $"{Name} (seed: {Seed})";
        }
    }
}
