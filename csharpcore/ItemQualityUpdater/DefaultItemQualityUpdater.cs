namespace csharpcore.ItemQualityUpdater
{
    internal class DefaultItemQualityUpdater : IItemQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                var qualityDecrease = item.SellIn > 0 ? 1 : 2;
                item.Quality -= qualityDecrease;
            }

            item.SellIn -= 1;
        }
    }
}
