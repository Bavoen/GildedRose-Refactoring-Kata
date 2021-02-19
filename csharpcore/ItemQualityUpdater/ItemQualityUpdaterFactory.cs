using System.Collections.Generic;

namespace csharpcore.ItemQualityUpdater
{
    internal class ItemQualityUpdaterFactory
    {
        private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const string CONJURED = "Conjured Mana Cake";

        private readonly Dictionary<string, IItemQualityUpdater> updaterMap;

        public ItemQualityUpdaterFactory()
        {
            updaterMap = new Dictionary<string, IItemQualityUpdater>
            {
                { AGED_BRIE, new AgedBrieQualityUpdater() },
                { BACKSTAGE_PASSES, new BackstagePassesQualityUpdater() },
                { SULFURAS, new SulfurasQualityUpdater() },
                { CONJURED, new ConjuredItemQualityUpdater() }
            };
        }

        public IItemQualityUpdater GetQualityUpdater(Item item)
        {
            return updaterMap.TryGetValue(item.Name, out var value) ? value : new DefaultItemQualityUpdater();
        }
    }
}
