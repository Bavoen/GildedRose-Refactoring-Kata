using csharpcore.ItemQualityUpdater;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        readonly IList<Item> Items;
        internal ItemQualityUpdaterFactory ItemQualityUpdaterFactory { get; }

        public GildedRose(IList<Item> items)
        {
            Items = items;
            ItemQualityUpdaterFactory = new ItemQualityUpdaterFactory();
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                var qualityUpdater = ItemQualityUpdaterFactory.GetQualityUpdater(item);
                qualityUpdater.UpdateQuality(item);
            }
        }
    }
}
