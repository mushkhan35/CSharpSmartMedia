using csharp.Enums;
using csharp.ItemRules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class GildedRose
    {
        private int _noOfDays { get; set; } = 31;

        public IList<Item> _items;

        public GildedRose(IList<Item> Items, int NoOfDays)
        {
            if (Items != null && NoOfDays > 0)
            {
                this._items = Items;
                this._noOfDays = NoOfDays;
            }
        }

        #region Private Methods

        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        public void CalculateAndPrintItemInfo()
        {
            int dayCounter = 0;
            while (dayCounter < _noOfDays)
            {
                Console.WriteLine("-------- day " + dayCounter + " --------");
                Console.WriteLine("name, sellIn, quality");

                _items.ToList().ForEach(item =>
                {
                    System.Console.WriteLine(item);
                    GildedRose.UpdateQuality(item);
                });
                Console.WriteLine("");
                dayCounter++;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateItemInfo()
        {
            int dayCounter = 0;
            while (dayCounter < _noOfDays)
            {
                _items.ToList().ForEach(item =>
                {
                    GildedRose.UpdateQuality(item);
                });
                dayCounter++;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static void UpdateQuality(Item item)
        {
            IItemRule itemType = null;
            switch (item.Name)
            {
                case ItemType.AgedBrie:
                    itemType = new AgedBrieItem();
                    itemType.ItemRule(item);
                    break;
                case ItemType.BackstagePass:
                    itemType = new BackstagePassItem();
                    itemType.ItemRule(item);
                    break;
                case ItemType.SulfurasHandRagnaros:
                    itemType = new SulfurasHandRagnaros();
                    itemType.ItemRule(item);
                    break;
                case ItemType.Conjured:
                    itemType = new ConjuredItem();
                    itemType.ItemRule(item);
                    break;
                default:
                    itemType = new StandardItem();
                    itemType.ItemRule(item);
                    break;
            }
        }
        #endregion
    }
}
