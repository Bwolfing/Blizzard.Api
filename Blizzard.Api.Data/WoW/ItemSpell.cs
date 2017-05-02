using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blizzard.Api.Data.WoW
{
    public class ItemSpell
    {
        public int SpellId { get; set; }

        public Spell Spell { get; set; }

        public int nCharges { get; set; }

        public bool Consumable { get; set; }

        public int CategoryId { get; set; }

        public string Trigger { get; set; }
    }
}
