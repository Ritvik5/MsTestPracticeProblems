using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestPracticeProblems
{
    public class ShopKeeper
    {
        public int SoldOnceItem(List<int> prices)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();

            foreach (int price in prices)
            {
                if (counter.ContainsKey(price))
                {
                    counter[price]++;
                }
                else
                {
                    counter[price] = 1;
                }
            }

            foreach (int price in prices)
            {
                if (counter[price] == 1)
                {
                    return price;
                }
            }
            return default;
        }

        public int SoldMoreThanOnceItem(List<int> prices)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();

            foreach (int price in prices)
            {
                if (counter.ContainsKey(price))
                {
                    counter[price]++;
                }
                else
                {
                    counter[price] = 1;
                }
            }

            foreach (int price in prices)
            {
                if (counter[price] > 1)
                {
                    return price;
                }
            }
            return default;
        }
    }
}
