using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    interface IEdevletValidationService
    {
        bool CheckCustomerInfo(IEntity entity);
    }
}
