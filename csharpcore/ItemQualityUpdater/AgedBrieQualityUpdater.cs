using System;

namespace csharpcore.ItemQualityUpdater
{
    internal class AgedBrieQualityUpdater : IItemQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            var qualityIncrease = item.SellIn > 0 ? 1 : 2;
            item.Quality = Math.Min(50, item.Quality + qualityIncrease);

            item.SellIn -= 1;
        }
    }
}
