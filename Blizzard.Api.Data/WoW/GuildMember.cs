using Blizzard.Api.Data.Internal.WoW;
using Blizzard.Api.Data.WoW.Enums;

namespace Blizzard.Api.Data.WoW
{
    public class GuildMember : ICharacter
    {
        public int Rank { get; set; }

        public string Name { get; set; }

        public string Realm { get; set; }

        public string BattleGroup { get; set; }

        public Class Class { get; set; }

        public Race Race { get; set; }

        public Gender Gender { get; set; }

        public Faction Faction => Convert.FromRace(Race);

        public int Level { get; set; }

        public string Thumbnail { get; set; }

        public int AchievementPoints { get; set; }

        public string Guild { get; set; }

        public string GuildRealm { get; set; }
    }
}
