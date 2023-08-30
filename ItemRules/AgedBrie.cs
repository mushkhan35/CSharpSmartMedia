namespace csharp.ItemRules
{
    internal class AgedBrie : IItemRule
    {
        public void UpdateItemRule(Item item)
        {
            item.Quality = item.Quality + 1;
            item.SellIn = item.SellIn - 1;
        }
    }
}
