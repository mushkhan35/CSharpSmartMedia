using System;

namespace csharp.ItemRules
{
    public class Conjured : IItemRule
    {
        public void UpdateItemRule(Item item)
        {
            item.SellIn--;
            item.Quality -= 2;
        }
    }
}
