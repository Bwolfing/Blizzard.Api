using System.Collections.Generic;

namespace Blizzard.Api.Data.WoW
{
    public class ItemTooltipParams
    {
        public List<int> GemIds { get; set; }

        public int? TransmogItemId { get; set; }

        public int? EnchantmentId { get; set; }

        public ItemUpgradeInfo Upgrade { get; set; }

        public List<int> ItemSetIds { get; set; }
    }
}
