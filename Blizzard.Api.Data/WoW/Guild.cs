using System.Collections.Generic;
using Blizzard.Api.Data.WoW.Enums;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class Guild
    {
        public string Name { get; set; }

        public RealmStatus Realm { get; set; }

        public int Level { get; set; }

        [JsonProperty("side")]
        public Faction Faction { get; set; }

        public int AchievementPoints { get; set; }

        public GuildEmblem Emblem { get; set; }

        public List<Character> Members { get; set; }

        public List<GuildNews> News { get; set; }
    }
}