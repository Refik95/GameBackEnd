using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    class SteamManager : ISteamSaleService
    {
        public void BuyGame(IEntity game, IEntity customer)
        {
            Console.WriteLine(customer.Name+ " : player has purchased the game called :" + game.Name);
        }
    }
}
