using System.Collections.Generic;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class ItemClass
    {
        [JsonProperty("class")]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<ItemSubClass> SubClasses { get; set; }
    }
}
