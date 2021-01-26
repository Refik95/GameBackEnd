using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    class SummerSaleManager : IDiscountService
    {
        public void Discount(IEntity game)
        {
            Console.WriteLine("The game called : " + game.Name + " is in the SummerSale discount now!");
        }
    }
}
