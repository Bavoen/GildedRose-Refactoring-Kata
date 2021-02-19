using System;

namespace csharpcore.ItemQualityUpdater
{
    internal class ConjuredItemQualityUpdater : IItemQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            var qualityDecrease = item.SellIn > 0 ? 2 : 4;
            item.Quality = Math.Max(0, item.Quality - qualityDecrease);

            item.SellIn -= 1;
        }
    }
}
