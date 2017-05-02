using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blizzard.Api.Data.WoW.Enums;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class RaceDataResource
    {
        public int Id { get; set; }

        public int Mask { get; set; }

        [JsonProperty("id")]
        public Race Race { get; set; }

        [JsonProperty("side")]
        public Faction Faction { get; set; }
    }
}
