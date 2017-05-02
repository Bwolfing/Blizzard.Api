using Blizzard.Api.Data.WoW.Enums;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class Specialization
    {
        public string Name { get; set; }

        [JsonIgnore]
        public Class ClassSpecBelongsTo { get; set; }

        public Role Role { get; set; }

        public bool Selected { get; set; }

        [JsonProperty("order")]
        public int SortOrder { get; set; }

        public string Description { get; set; }
    }
}