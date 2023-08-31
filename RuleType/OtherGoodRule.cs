namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    public class OtherGoodRule : UniversalRule
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public override void ItemRule(Item item)
        {
            this.UniversalRuleApply(item);
        }
    }
}
