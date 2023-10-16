using GildedRoseNS;
using System.Collections.Generic;
using System.Diagnostics;

namespace GildedRoseNS {

    public class GildedRose {

        public IList<Item> Items;

        public Dictionary<string, ItemtoSell> itemTypes = new Dictionary<string, ItemtoSell>()
        {
            {"Aged Brie", new BrieItem() },
            { "Sulfuras, Hand of Ragnaros", new LegendaryItem()},
            {"Backstage passes to a TAFKAL80ETC concert", new BackstageItem()},
            { "Conjured", new ConjuredItem()},
            { "Mystical Elixir", new ElixirItem()},
            { "Regular", new RegularItem()}
        };

        public GildedRose(IList<Item> items){
            Items = items;
        }

        public void UpdateQuality(){
            foreach(var item in Items)
            {
                if (itemTypes.ContainsKey(item.Name))
                {
                    itemTypes[item.Name].changeQuality(item);
                }
                else {
                    itemTypes["Regular"].changeQuality(item);
                }
            }
        }
    }

    public class Item {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}