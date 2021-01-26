using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    interface IDiscountService
    {
        void Discount(IEntity entity);
    }
}
