namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    public class AgedBrieItem : GeneralItem, IItemRule
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public override void ItemRule(Item item)
        {
            this.GeneralRule(item);
        }
    }
}
