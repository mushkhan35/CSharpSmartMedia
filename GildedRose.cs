using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class GildedRose
    {

        private int _noOfDays { get; set; } = 31;

        public IList<Item> Items;

        /// <summary>
        /// 
        /// </summary>
        public GildedRose()
        {

        }


        public GildedRose(IList<Item> Items, int NoOfDays)
        {
            if (Items != null && NoOfDays > 0)
            {
                this.Items = Items;
                this._noOfDays = NoOfDays;
            }
        }

        #region Private Methods



        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        public void PrintItemInfoConsole()
        {
            int dayCounter = 0;
            while (dayCounter < _noOfDays)
            {
                Console.WriteLine("-------- day " + dayCounter + " --------");
                Console.WriteLine("name, sellIn, quality");

                Items.ToList().ForEach(x =>
                {
                    System.Console.WriteLine(x);

                });
                Console.WriteLine("");
                this.UpdateQuality();
                dayCounter++;
            }
        }

        public void UpdateItemInfo()
        {
            int dayCounter = 0;
            while (dayCounter < _noOfDays)
            {
                this.UpdateQuality();
                dayCounter++;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                // "Aged Brie" actually increases in Quality the older it gets
                // At the end of each day our system lowers both values for every item
                if (Items[i].Name == "Aged Brie")
                {
                    Items[i].Quality = Items[i].Quality + 1;
                    Items[i].SellIn = Items[i].SellIn - 1;
                }
                // "Sulfuras", being a legendary item, never has to be sold or decreases in Quality					
                else if (Items[i].Name == "Sulfuras, Hand of Ragnaros")
                {
                }

                //Backstage passes", like aged brie, increases in Quality as it's SellIn value approaches; Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 //after the concert
                else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    Items[i].SellIn--;

                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality += 1;

                        if (Items[i].Quality < 50)
                        {
                            if (Items[i].SellIn <= 10)
                            {
                                Items[i].Quality += 1;
                            }

                            if (Items[i].SellIn <= 5)
                            {
                                Items[i].Quality += 1;
                            }

                            if (Items[i].SellIn < 0)
                            {
                                Items[i].Quality = 0;
                            }
                        }
                    }
                }
                else
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                    Items[i].Quality = Items[i].Quality - 1;

                    if (Items[i].SellIn < 0)
                    {
                        Items[i].Quality = Items[i].Quality - 1;
                    }
                }
            }
        }


        #endregion
    }
}
