using csharpcore.ItemQualityUpdater;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const string CONJURED = "Conjured Mana Cake";

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
                if(item.Name != AGED_BRIE && item.Name != BACKSTAGE_PASSES && item.Name != SULFURAS && item.Name != CONJURED)
                {
                    var qualityUpdater = ItemQualityUpdaterFactory.GetQualityUpdater(item);
                    qualityUpdater.UpdateQuality(item);
                }
                else
                {
                    LegacyUpdateQuality(item);
                }
            }
        }

        public void LegacyUpdateQuality(Item item)
        {
            if (item.Name != AGED_BRIE && item.Name != BACKSTAGE_PASSES)
            {
                if (item.Quality > 0)
                {
                    if (item.Name != SULFURAS)
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.Name == BACKSTAGE_PASSES)
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                    }
                }
            }

            if (item.Name != SULFURAS)
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != AGED_BRIE)
                {
                    if (item.Name != BACKSTAGE_PASSES)
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != SULFURAS)
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }
    }
}
