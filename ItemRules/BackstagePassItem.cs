namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    internal class BackstagePassItem : GeneralItem, IItemRule
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public override void ItemRule(Item item)
        {

            this.GeneralRule(item);

            // Quality increases by 2 when there are 10 days or less..
            if (item.SellIn > 5 && item.SellIn <= 10)
            {
                item.Quality += 1;
            }

            // .. and by 3 when there are 5 days or less
            // .. but Quality drops to 0 after the concert
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
