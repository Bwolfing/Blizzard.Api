using System.Collections.Generic;
using Blizzard.Api.Data.WoW.Enums;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class Achievement
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Points { get; set; }

        public string Description { get; set; }

        //TODO: Include Reward Items array

        public string Icon { get; set; }

        public List<Criterion> Criteria { get; set; }

        public bool AccountWide { get; set; }

        [JsonProperty("factionId")]
        public Faction Faction { get; set; }
    }
}
