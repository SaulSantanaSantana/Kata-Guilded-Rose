using GildedRoseNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseNS
{
    public class RegularItem : ItemtoSell{

        public override void changeQuality(Item item)
        {
            if (item.Quality > 0 && item.Quality < 50) {
                if (item.SellIn == 0)
                {
                    item.Quality = item.Quality - 2;
                }
                else
                {
                    item.Quality--;
                }
            }

            item.SellIn--;
        }
    }

    public class BrieItem : ItemtoSell
    {

        public override void changeQuality(Item item)
        {

            if (item.Quality > 0 && item.Quality < 50) {
                if (item.SellIn == 0)
                {
                    item.Quality = item.Quality + 2;
                }
                else
                {
                    item.Quality++;
                }
            }
                
            item.SellIn--;
        }
    }

    public class ConjuredItem : ItemtoSell
    {

        public override void changeQuality(Item item)
        {
            if (item.Quality < 4 && item.SellIn == 0) { 
                item.Quality = 0;
            }else if (item.Quality > 0 && item.Quality < 50) {
                if (item.SellIn == 0)
                {
                    item.Quality = item.Quality - 4;
                }
                else
                {
                    item.Quality = item.Quality - 2;
                }
            } 

            item.SellIn--;
        }
    }

    public class BackstageItem : ItemtoSell
    {

        public override void changeQuality(Item item)
        {
            if (item.Quality > 0 && item.Quality < 50) {
                if (item.SellIn == 0)
                {
                    item.Quality = 0;
                }
                else if (item.SellIn <= 5)
                {
                    item.Quality = item.Quality + 3;
                }
                else if (item.SellIn <= 10)
                {
                    item.Quality = item.Quality + 2;
                }
                else
                {
                    item.Quality++;
                }
            }

            item.SellIn--;
        }
    }

    public class LegendaryItem : ItemtoSell
    {
        public override void changeQuality(Item item){;}
    }

    public class ElixirItem : ItemtoSell
    {
        public override void changeQuality(Item item) {

            if (item.Quality > 0 && item.Quality <= 50) {
                
                if (item.SellIn == 3)
                {
                    if (item.Quality <= 40)
                    {
                        item.Quality += 10;
                    }
                    else {
                        item.Quality = 50;
                    }
                    
                }
                else if (item.SellIn > 0)
                {
                    item.Quality = item.Quality - 2;
                }
                else
                {
                    item.Quality = item.Quality - 2;
                }
            }

            item.SellIn--;
        }
    }


    public abstract class ItemtoSell : Item {
        public abstract void changeQuality(Item item);
    }
}
