namespace csharp.ItemRules
{
    internal class SulfurasHandRagnarosRule : UniversalRule
    {

        /// <summary>
        /// "Sulfuras", being a legendary item, never has to be sold or decreases in Quality. No Rule Apply
        /// </summary>
        /// <param name="item"></param>
        public override void ItemRule(Item item)
        {
        }
    }
}
