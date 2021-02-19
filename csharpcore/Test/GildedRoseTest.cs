using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace csharpcore.Test
{
    public class GildedRoseTest
    {
        [Fact]
        public void DefaultItemUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "default_item", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(9);
            items[0].Quality.Should().Be(9);
        }

        [Fact]
        public void DefaultItemAfterSellDateUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "default_item", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(-1);
            items[0].Quality.Should().Be(8);
        }

        [Fact]
        public void DefaultItemQualityZeroUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "default_item", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(9);
            items[0].Quality.Should().Be(0);
        }

        [Fact]
        public void AgedBrieUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(9);
            items[0].Quality.Should().Be(11);
        }

        [Fact]
        public void AgedBrieAfterSellDateUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(-1);
            items[0].Quality.Should().Be(12);
        }

        [Fact]
        public void AgedBrieQualityFiftyUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(9);
            items[0].Quality.Should().Be(50);
        }

        [Fact]
        public void SulfurasUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(10);
            items[0].Quality.Should().Be(10);
        }

        [Fact]
        public void SulfurasAtSellInZeroUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(0);
            items[0].Quality.Should().Be(10);
        }

        [Fact]
        public void SulfurasQualityEightyUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(10);
            items[0].Quality.Should().Be(80);
        }

        [Fact]
        public void BackStagePassAtSellInZeroMoreThenTenDaysUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(19);
            items[0].Quality.Should().Be(11);
        }

        [Fact]
        public void BackStagePassAtSellInTenDaysUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(9);
            items[0].Quality.Should().Be(12);
        }

        [Fact]
        public void BackStagePassAtSellInSixDaysUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(5);
            items[0].Quality.Should().Be(12);
        }

        [Fact]
        public void BackStagePassAtSellInFiveDaysUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(4);
            items[0].Quality.Should().Be(13);
        }

        [Fact]
        public void BackStagePassAtSellInOneDayUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(0);
            items[0].Quality.Should().Be(13);
        }

        [Fact]
        public void BackStagePassAtSellInZeroDayUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(-1);
            items[0].Quality.Should().Be(0);
        }

        [Fact]
        public void ConjuredItemUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(9);
            items[0].Quality.Should().Be(8);
        }

        [Fact]
        public void ConjuredItemAfterSellDateUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(-1);
            items[0].Quality.Should().Be(6);
        }

        [Fact]
        public void ConjuredItemQualityZeroUpdate()
        {
            // Given
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(items);

            // When
            app.UpdateQuality();

            // Assert
            items[0].SellIn.Should().Be(9);
            items[0].Quality.Should().Be(0);
        }
    }
}