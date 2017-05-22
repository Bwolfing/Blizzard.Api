using Blizzard.Api.Data.WoW.Enums;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class SpecializationDescription
    {
        public string Name { get; set; }

        public Role Role { get; set; }

        public string BackgroundImage { get; set; }

        public string Icon { get; set; }

        [JsonProperty("order")]
        public int SortOrder { get; set; }

        public string Description { get; set; }
    }
}
