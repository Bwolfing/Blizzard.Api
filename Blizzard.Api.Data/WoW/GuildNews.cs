using Blizzard.Api.Data.WoW.Enums;
using System;
using System.Collections.Generic;

namespace Blizzard.Api.Data.WoW
{
    public class GuildNews
    {
        public GuildNewsType Type { get; set; }

        public string CharacterName { get; set; }

        public long BattleNetTimestamp { get; set; }

        public DateTime DateTimeTimestamp { get; set; }

        public string Context { get; set; }

        public List<int> BonusLists { get; set; }
    }
}
