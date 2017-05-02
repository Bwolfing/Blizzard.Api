using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blizzard.Api.Data.WoW
{
    public class BonusChance
    {
        public string ChanceType { get; set; }

        public List<BonusChanceStat> Stats { get; set; }

        public List<BonusChanceSocket> Sockets { get; set; }
    }
}
