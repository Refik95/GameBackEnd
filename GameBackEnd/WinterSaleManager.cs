using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    class WinterSaleManager : IDiscountService
    {
        public void Discount(IEntity game)
        {
            Console.WriteLine("The game called : " + game.Name + " is in the WinterSale discount now!");
        }
    }
}
