using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class Title
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Selected { get; set; }
    }
}