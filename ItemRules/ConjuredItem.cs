
namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    public class ConjuredItem : GeneralItem, IItemRule
    {
        /// <summary>
        ///  "Conjured" items degrade in Quality twice as fast as normal items
        /// </summary>
        /// <param name="item"></param>
        public override void ItemRule(Item item)
        {
            this.GeneralRule(item);
            item.Quality -= 1;
        }
    }
}
