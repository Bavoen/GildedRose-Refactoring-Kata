using System;

namespace csharpcore.ItemQualityUpdater
{
    internal class DefaultItemQualityUpdater : IItemQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            var qualityDecrease = item.SellIn > 0 ? 1 : 2;
            item.Quality = Math.Max(0, item.Quality - qualityDecrease);

            item.SellIn -= 1;
        }
    }
}
