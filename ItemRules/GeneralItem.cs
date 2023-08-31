
namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class GeneralItem
    {
        public abstract void ItemRule(Item item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void GeneralRule(Item item)
        {
            // The Quality of an item is never more than 50
            if (item.Quality > 0 && item.Quality < 50)
                item.Quality++;
            // The Quality of an item is never negative
            if (item.Quality < 0)
                item.Quality = 0;

            item.SellIn--;

            //Once the sell by date has passed, Quality degrades twice as fast
            if (item.SellIn < 0)
                item.SellIn = item.SellIn - 1;
        }
    }
}
