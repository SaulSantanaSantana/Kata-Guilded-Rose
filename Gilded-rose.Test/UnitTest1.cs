using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Gilded_rose;
using NUnit.Framework;

namespace KataGildedRose.Tests
{
    public class GildedRoseTest
    {
        
        [Test]
        public void think_a_good_name_and_change_it()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal item", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Name.Should().Be("Normal item");
        }
    }
}