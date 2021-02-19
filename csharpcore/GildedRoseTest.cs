using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void DefaultItemUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "default_item", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            
            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(9);
            Items[0].Quality.Should().Be(9);
        }

        [Fact]
        public void DefaultItemAfterSellDateUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "default_item", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(-1);
            Items[0].Quality.Should().Be(8);
        }

        [Fact]
        public void DefaultItemQualityZeroUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "default_item", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(9);
            Items[0].Quality.Should().Be(0);
        }

        [Fact]
        public void AgedBrieUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(9);
            Items[0].Quality.Should().Be(11);
        }

        [Fact]
        public void AgedBrieAfterSellDateUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(-1);
            Items[0].Quality.Should().Be(12);
        }

        [Fact]
        public void AgedBrieQualityFiftyUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(9);
            Items[0].Quality.Should().Be(50);
        }

        [Fact]
        public void SulfurasUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(10);
            Items[0].Quality.Should().Be(10);
        }

        [Fact]
        public void SulfurasAtSellInZeroUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(0);
            Items[0].Quality.Should().Be(10);
        }

        [Fact]
        public void SulfurasQualityEightyUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(10);
            Items[0].Quality.Should().Be(80);
        }

        [Fact]
        public void BackStagePassAtSellInZeroMoreThenTenDaysUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(19);
            Items[0].Quality.Should().Be(11);
        }

        [Fact]
        public void BackStagePassAtSellInTenDaysUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(9);
            Items[0].Quality.Should().Be(12);
        }

        [Fact]
        public void BackStagePassAtSellInSixDaysUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(5);
            Items[0].Quality.Should().Be(12);
        }

        [Fact]
        public void BackStagePassAtSellInFiveDaysUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(4);
            Items[0].Quality.Should().Be(13);
        }

        [Fact]
        public void BackStagePassAtSellInOneDayUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(0);
            Items[0].Quality.Should().Be(13);
        }

        [Fact]
        public void BackStagePassAtSellInZeroDayUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(-1);
            Items[0].Quality.Should().Be(0);
        }

        [Fact(Skip = "Not implemented yet")]
        public void ConjuredItemUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(9);
            Items[0].Quality.Should().Be(8);
        }

        [Fact(Skip = "Not implemented yet")]
        public void ConjuredItemAfterSellDateUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(-1);
            Items[0].Quality.Should().Be(6);
        }

        [Fact(Skip = "Not implemented yet")]
        public void ConjuredItemQualityZeroUpdate()
        {
            // Given
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            // When
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(9);
            Items[0].Quality.Should().Be(0);
        }
    }
}