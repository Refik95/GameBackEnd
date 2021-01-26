using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    class EdevletValidationManager : IEdevletValidationService
    {
        public bool CheckCustomerInfo(IEntity entity)
        {
            Console.WriteLine("Real Customer");
            return true;
        }
    }
}
