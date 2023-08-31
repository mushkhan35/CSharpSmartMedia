
namespace csharp.ItemRules
{
    /// <summary>
    /// 
    /// </summary>
    public class ConjuredRule : UniversalRule
    {
        /// <summary>
        ///  "Conjured" items degrade in Quality twice as fast as normal items
        /// </summary>
        /// <param name="item"></param>
        public override void ItemRule(Item item)
        {
            this.UniversalRuleApply(item);
            this.ConjuredRuleApply(item);
        }


        private void ConjuredRuleApply(Item item)
        {

            item.Quality -= 1;
        }
    }
}
