namespace csharpcore.ItemQualityUpdater
{
    internal class ItemQualityUpdaterFactory
    {
        public IItemQualityUpdater GetQualityUpdater(Item item)
        {
            return new DefaultItemQualityUpdater();
        }
    }
}
