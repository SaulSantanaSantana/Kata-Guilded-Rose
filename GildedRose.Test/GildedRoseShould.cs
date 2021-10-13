using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRose.Test {
    public class GildedRoseShould {
        [Test]
        public void change_test_name() {
            var gildedRose = new GildedRose(new List<Item>());

            gildedRose.UpdateQuality();


        }
    }
}