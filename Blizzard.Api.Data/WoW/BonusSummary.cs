using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blizzard.Api.Data.WoW
{
    public class BonusSummary
    {
        public List<int> DefaultBonusLists { get; set; }

        public List<int> ChanceBonusLists { get; set; }

        public List<BonusChance> BonusChances { get; set; }
    }
}
