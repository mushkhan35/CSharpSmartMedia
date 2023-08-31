
using System.Diagnostics;
using System.Security.Policy;

namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class UniversalRule : IItemRule
    {
        public abstract void ItemRule(Item item);

        /// <summary>
        /// * At the end of each day our system lowers both values for every item         
        /// * Once the sell by date has passed, Quality degrades twice as fast 
        /// * The Quality of an item is never negative 
        /// * The Quality of an item is never more than 50 
        /// </summary>
        /// <param name="item"></param>
        public void UniversalRuleApply(Item item)
        {            
            item.SellIn--;
            item.Quality--;       

            // Once the sell by date has passed, Quality degrades twice as fast
            if (item.SellIn < 0)
                item.Quality--;

            if (item.Quality < 0 || item.Quality > 50) {
                item.Quality = 0; item.SellIn = 0;
            }
        }
    }
}
