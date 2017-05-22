using Blizzard.Api.Data.WoW.Enums;

namespace Blizzard.Api.Data.WoW
{
    public interface ICharacter
    {
        string Name { get; set; }

        string Realm { get; set; }

        string BattleGroup { get; set; }

        Class Class { get; set; }

        Race Race { get; set; }

        Gender Gender { get; set; }

        Faction Faction { get; }

        int Level { get; set; }

        string Thumbnail { get; set; }

        int AchievementPoints { get; set; }
    }
}
