using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class Spell
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Icon { get; set; }

        public string Description { get; set; }

        public string Range { get; set; }

        public string CastTime { get; set; }

        public string CoolDown { get; set; }

        public string PowerCost { get; set; }

        [JsonProperty("spec")]
        public SpecializationDescription Specialization { get; set; }
    }
}
