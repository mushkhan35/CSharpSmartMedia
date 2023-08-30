
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
            item.Quality++;
            item.SellIn--;
        }
    }
}
