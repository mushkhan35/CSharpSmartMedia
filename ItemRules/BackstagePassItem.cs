namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    internal class BackstagePassItem : GeneralItem, IItemRule
    {
        /// <summary>
        /// "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
        /// Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
        /// Quality drops to 0 after the concert
        /// </summary>
        /// <param name="item"></param>
        public override void ItemRule(Item item)
        {

            this.GeneralRule(item);

            // Quality increases by 2 when there are 10 days or less..
            // The Quality of an item is never more than 50
            // by 3 when there are 5 days or less
            if (item.Quality < 50)
            {
                if (item.SellIn <= 10)
                {
                    item.Quality += 1;
                }

                if (item.SellIn <= 5)
                {
                    item.Quality += 1;
                }
            }

            
            // Quality drops to 0 after the concert
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
