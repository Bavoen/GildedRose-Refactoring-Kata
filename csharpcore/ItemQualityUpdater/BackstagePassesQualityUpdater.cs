using System;

namespace csharpcore.ItemQualityUpdater
{
    internal class BackstagePassesQualityUpdater : IItemQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            if(item.SellIn <= 0)
            {
                item.Quality = 0;
                item.SellIn -= 1;
                return;
            }

            var qualityIncrease = 1;
            if (item.SellIn <= 10)
            {
                qualityIncrease = 2;
            }
            if (item.SellIn <= 5)
            {
                qualityIncrease = 3;
            }

            item.Quality = Math.Min(50, item.Quality + qualityIncrease);

            item.SellIn -= 1;
        }
    }
}
