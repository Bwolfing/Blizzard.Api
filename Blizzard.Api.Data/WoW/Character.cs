using Blizzard.Api.Data.WoW.Enums;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Blizzard.Api.Data.Internal.WoW;
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
        
        public Faction Faction => Convert.FromRace(Race);

        public int Level { get; set; }

        public string Thumbnail { get; set; }

        public int AchievementPoints { get; set; }

        public int TotalHonorableKills { get; set; }

        public CharacterGuild Guild { get; set; }

        [JsonProperty("spec")]
        public Specialization Specialization { get; set; }

        public IList<Title> Titles { get; set; }

        public Stats Stats { get; set; }

        public CharacterEquipment Items { get; set; }

        public IList<Specialization> Talents { get; set; }
    }
}