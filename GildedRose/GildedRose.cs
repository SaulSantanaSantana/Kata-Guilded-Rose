using System.Collections.Generic;
using System.Diagnostics;

namespace GildedRoseNS {

    public class GildedRose {

        public IList<Item> Items;

        public GildedRose(IList<Item> items) {
            Items = items;
        }

        public void UpdateQuality(){

            foreach (var item in Items) {
                if (item.Name.Equals("Sulfuras, Hand of Ragnaros")) {
                    //Sulfuras UWU
                    continue;
                }else if (item.Quality > 0 && item.Quality < 50) {
                    switch (item.Name) {

                        case "Aged Brie":
                            brieQuialityChange(item);
                            break;

                        case "Backstage passes to a TAFKAL80ETC concert":
                            backstageQualityChange(item);
                            break;

                        case "Conjured":
                            conjuredQualityChange(item);
                            break;

                        default:
                            generalQualityChange(item);
                            break;
                    }
                }

                item.SellIn--;
            }
        }

        private void generalQualityChange(Item item) {
            if (item.SellIn == 0) {
                item.Quality = item.Quality - 2 ;
            }
            else{
                item.Quality--;
            }

        }

        private void brieQuialityChange(Item item){
            if (item.SellIn == 0) {
                item.Quality = item.Quality + 2;
            }
            else {
                item.Quality++;
            }
        }

        private void backstageQualityChange(Item item){
            if (item.SellIn == 0){
                item.Quality = 0;
            }
            else if (item.SellIn <= 5) {
                item.Quality = item.Quality + 3;
            }
            else if (item.SellIn <= 10){
                item.Quality = item.Quality + 2;
            }
            else {
                item.Quality++;
            }
        }

        private void conjuredQualityChange(Item item){
            if (item.SellIn == 0){
                item.Quality = item.Quality - 4;
            }
            else{
                item.Quality = item.Quality - 2;
            }
        }
    }

    public class Item {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}