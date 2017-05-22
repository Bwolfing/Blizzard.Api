namespace Blizzard.Api.Data.WoW
{
    public class GoldValue
    {
        private const double CopperInSilver = 100;
        private const double SilverInGold = 100;

        public double ValueInCopper { get; set; }

        public double ValueInSilver => ValueInCopper / CopperInSilver;

        public double ValueInGold => ValueInSilver / SilverInGold;

        public GoldValue()
        {
        }

        public GoldValue(double copper)
        {
            ValueInCopper = copper;
        }
    }
}