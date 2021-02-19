using csharpcore.ItemQualityUpdater;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace csharpcore.Test
{
    public class ItemQualityUpdaterFactoryTest
    {
        [Fact]
        public void DefaultItemUpdater1()
        {
            // Given
            var item = new Item { Name = "default_item", SellIn = 10, Quality = 10 };
            var qualityUpdaterFactory = new ItemQualityUpdaterFactory();

            // When
            var qualityUpdater = qualityUpdaterFactory.GetQualityUpdater(item);

            // Assert
            qualityUpdater.Should().BeOfType<DefaultItemQualityUpdater>();
        }

        [Fact]
        public void DefaultItemUpdater2()
        {
            // Given
            var item = new Item { Name = "other_default_item", SellIn = 10, Quality = 10 };
            var qualityUpdaterFactory = new ItemQualityUpdaterFactory();

            // When
            var qualityUpdater = qualityUpdaterFactory.GetQualityUpdater(item);

            // Assert
            qualityUpdater.Should().BeOfType<DefaultItemQualityUpdater>();
        }

        [Fact]
        public void AgedBrieItemUpdater()
        {
            // Given
            var item = new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 };
            var qualityUpdaterFactory = new ItemQualityUpdaterFactory();

            // When
            var qualityUpdater = qualityUpdaterFactory.GetQualityUpdater(item);

            // Assert
            qualityUpdater.Should().BeOfType<AgedBrieQualityUpdater>();
        }

        [Fact]
        public void BackstagePassesItemUpdater()
        {
            // Given
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 };
            var qualityUpdaterFactory = new ItemQualityUpdaterFactory();

            // When
            var qualityUpdater = qualityUpdaterFactory.GetQualityUpdater(item);

            // Assert
            qualityUpdater.Should().BeOfType<BackstagePassesQualityUpdater>();
        }

        [Fact]
        public void SulfurasItemUpdater()
        {
            // Given
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 };
            var qualityUpdaterFactory = new ItemQualityUpdaterFactory();

            // When
            var qualityUpdater = qualityUpdaterFactory.GetQualityUpdater(item);

            // Assert
            qualityUpdater.Should().BeOfType<SulfurasQualityUpdater>();
        }

        [Fact]
        public void ConjuredItemUpdater()
        {
            // Given
            var item = new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 10 };
            var qualityUpdaterFactory = new ItemQualityUpdaterFactory();

            // When
            var qualityUpdater = qualityUpdaterFactory.GetQualityUpdater(item);

            // Assert
            qualityUpdater.Should().BeOfType<ConjuredItemQualityUpdater>();
        }
    }
}
