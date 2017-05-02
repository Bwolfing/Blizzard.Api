using Blizzard.Api.Data.Core;
using Blizzard.Api.Data.WoW.Enums;
using System.Collections.Generic;

namespace Blizzard.Api.Data.WoW
{
    public class RealmStatus
    {
        public RealmType Type { get; set; }

        public RealmPopulation Population { get; set; }

        public bool Queue { get; set; }

        public bool Status { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string BattleGroup { get; set; }

        public Locale Locale { get; set; }

        public string Timezone { get; set; }

        public List<string> ConnectedRealms { get; set; }
    }
}
