namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    public class AgedBrieRule : UniversalRule
    {
        /// <summary>
        /// "Aged Brie" actually increases in Quality the older it gets
        /// </summary>
        /// <param name="item"></param>
        public override void ItemRule(Item item)
        {
            this.UniversalRuleApply(item);
        }
    }
}
