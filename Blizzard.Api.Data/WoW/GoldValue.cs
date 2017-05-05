using Blizzard.Api.Data.Json;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    [JsonConverter(typeof(GoldValueConverter))]
    public class GoldValue
    {
        private const double CopperInSilver = 100;
        private const double SilverInGold = 100;

        public double ValueInCopper { get; set; }

        public double ValueInSilver => ValueInCopper / CopperInSilver;

        public double ValueInGold => ValueInSilver / SilverInGold;

    }
}