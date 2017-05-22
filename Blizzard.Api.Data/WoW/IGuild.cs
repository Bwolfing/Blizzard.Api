namespace Blizzard.Api.Data.WoW
{
    public interface IGuild
    {
        string Name { get; set; }

        string Realm { get; set; }

        string BattleGroup { get; set; }

        int AchievementPoints { get; set; }

        GuildEmblem Emblem { get; set; }
    }
}
