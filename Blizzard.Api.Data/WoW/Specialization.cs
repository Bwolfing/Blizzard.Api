using Newtonsoft.Json;
using System.Collections.Generic;

namespace Blizzard.Api.Data.WoW
{
    public class Specialization
    {
        public bool Selected { get; set; }

        public IList<Talent> Talents { get; set; }

        [JsonProperty("spec")]
        public SpecializationDescription Description { get; set; }

        public string CalcTalent { get; set; }

        public string CalcSpec { get; set; }
    }
}