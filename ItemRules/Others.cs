using System;

namespace csharp.ItemRules
{
    public class Others : IItemRule
    {
        public void UpdateItemRule(Item item)
        {
            item.SellIn = item.SellIn - 1;
            item.Quality = item.Quality - 1;

            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - 1;
            }
        }
    }
}
