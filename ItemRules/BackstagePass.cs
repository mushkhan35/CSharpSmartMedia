namespace csharp.ItemRules
{
    internal class BackstagePass :  IItemRule
    {
        public void UpdateItemRule(Item item)
        {
            item.SellIn--;

            if (item.Quality < 50)
            {
                item.Quality += 1;

                if (item.Quality < 50)
                {
                    if (item.SellIn <= 10)
                    {
                        item.Quality += 1;
                    }

                    if (item.SellIn <= 5)
                    {
                        item.Quality += 1;
                    }

                    if (item.SellIn < 0)
                    {
                        item.Quality = 0;
                    }
                }
            }
        }
    }
}
