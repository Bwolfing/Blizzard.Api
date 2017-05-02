using Blizzard.Api.Data.WoW.Enums;
using Newtonsoft.Json;

namespace Blizzard.Api.Data.WoW
{
    public class Stats
    {
        public int Health { get; set; }

        public PowerType PowerType { get; set; }

        public int Power { get; set; }

        #region Main character stats
        [JsonProperty("str")]
        public int Strength { get; set; }

        [JsonProperty("agi")]
        public int Agility { get; set; }

        [JsonProperty("int")]
        public int Intellect { get; set; }

        [JsonProperty("sta")]
        public int Stamina { get; set; }
        #endregion

        public double SpeedRating { get; set; }

        public double SpeedRatingBonus { get; set; }

        public double Crit { get; set; }

        public int CritRating { get; set; }

        public double Haste { get; set; }

        public int HasteRating { get; set; }

        public double HasteRatingPercent { get; set; }

        public double Mastery { get; set; }

        public int MasteryRating { get; set; }

        public double Leech { get; set; }

        public double LeechRating { get; set; }

        public double LeechRatingBonus { get; set; }

        public int Versatility { get; set; }

        public double VersatilityDamageDoneBonus { get; set; }

        public double VersatilityHealingDoneBonus { get; set; }

        public double VersatilityDamageTakenBonus { get; set; }

        public double AvoidanceRating { get; set; }

        public double AvoidanceRatingBonus { get; set; }

        [JsonProperty("spellPen")]
        public double SpellPenetration { get; set; }

        public double SpellCrit { get; set; }

        public int SpellCritRating { get; set; }

        public double Mana5 { get; set; }

        public double Mana5Combat { get; set; }

        #region Defensive stats
        public int Armor { get; set; }

        public double Dodge { get; set; }

        public int DodgeRating { get; set; }

        public double Parry { get; set; }

        public int ParryRating { get; set; }

        public double Block { get; set; }

        public int BlockRating { get; set; }
        #endregion

        #region Weapon damage stats
        #region Main hand
        public double MainHandDamageMin { get; set; }

        public double MainHandDamageMax { get; set; }

        public double MainHandSpeed { get; set; }

        public double MainHandDps { get; set; }
        #endregion

        #region Offhand
        public double OffHandDamageMin { get; set; }

        public double OffHandDamageMax { get; set; }

        public double OffHandSpeed { get; set; }

        public double OffHandDps { get; set; }
        #endregion

        #region Ranged
        public double RangedDamageMin { get; set; }

        public double RangedDamageMax { get; set; }

        public double RangedSpeed { get; set; }

        public double RangedDps { get; set; }
        #endregion
        #endregion
    }
}