using Blizzard.Api.Data.WoW.Enums;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class Character
    {
        public string Name { get; set; }

        public string Realm { get; set; }

        public Class Class { get; set; }

        public Race Race { get; set; }

        public Gender Gender { get; set; }
        
        // TODO: Replace with Get-only, which determines based on race
        [JsonIgnore]
        public Faction Faction { get; set; }

        public int Level { get; set; }

        public string Thumbnail { get; set; }

        public int AchievementPoints { get; set; }

        public int TotalHonorableKills { get; set; }

        public Guild Guild { get; set; }

        [JsonProperty("spec")]
        public Specialization Specialization { get; set; }

        public IList<Title> Titles { get; set; }

        public Stats Stats { get; set; }

        public CharacterEquipment Items { get; set; }
    }
}