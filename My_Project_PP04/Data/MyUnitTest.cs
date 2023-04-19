using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project_PP04.Data
{
    public class MyUnitTest
    {
        static public int ResultAllPrice(Baskets baskets)
        {
            int result = 0;
            foreach (var item in baskets.Basket)
            {
                result = result+ item.Count * item.Price;
            }
            return result;
        }
    }
}
