using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blizzard.Api.Data.WoW.Enums;

namespace Blizzard.Api.Data.Internal.WoW
{
    internal static class Convert
    {
        public static Faction FromRace(Race race)
        {
            switch (race)
            {
                case Race.BloodElf:
                case Race.Goblin:
                case Race.Orc:
                case Race.PandarenHorde:
                case Race.Tauren:
                case Race.Troll:
                case Race.Undead:
                    return Faction.Horde;
                case Race.Draenei:
                case Race.Dwarf:
                case Race.Gnome:
                case Race.PandarenAlliance:
                case Race.NightElf:
                case Race.Worgen:
                case Race.Human:
                    return Faction.Alliance;
                case Race.PandarenNeutral:
                    return Faction.Neutral;
                default:
                    return Faction.NULL;
            }
        }
    }
}
