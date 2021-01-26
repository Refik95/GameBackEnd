using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    interface ISteamSaleService
    {
        void BuyGame(IEntity game, IEntity customer);
    }
}
