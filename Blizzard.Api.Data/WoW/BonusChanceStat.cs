using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class BonusChanceStat
    {
        [JsonProperty("statId")]
        public string Stat { get; set; }

        public int Delta { get; set; }
    }
}
