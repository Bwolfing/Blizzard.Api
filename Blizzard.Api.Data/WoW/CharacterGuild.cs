namespace Blizzard.Api.Data.WoW
{
    public class CharacterGuild
    {
        public string Name { get; set; }

        public string Realm { get; set; }

        public string BattleGroup { get; set; }

        public int Members { get; set; }

        public int AchievementPoints { get; set; }

        public GuildEmblem Emblem { get; set; }
    }
}
