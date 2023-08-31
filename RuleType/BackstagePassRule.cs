namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    internal class BackstagePassRule : UniversalRule
    {
        /// <summary>
        /// "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
        /// Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
        /// Quality drops to 0 after the concert
        /// </summary>
        /// <param name="item"></param>
        public override void ItemRule(Item item)
        {

            this.BackstagePassRuleApply(item);
        }

        private void BackstagePassRuleApply(Item item)
        {

            if (item.SellIn > 0 && item.Quality < 50)
            {
                if (item.SellIn <= 10)
                {
                    item.Quality += 2;
                }

                if (item.SellIn <= 5)
                {
                    item.Quality++;
                }                
            }
            if (item.SellIn <= 0)
                item.Quality = 0;
        }
    }
}
