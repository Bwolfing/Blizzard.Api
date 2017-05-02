using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class ItemSubClass
    {
        [JsonProperty("subclass")]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
