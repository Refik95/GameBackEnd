using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    class CustomerManager : ICustomerDal
    {
        private IEdevletValidationService _edevletValidationService;
        public CustomerManager(IEdevletValidationService edevletValidationService)
        {
            _edevletValidationService = edevletValidationService;
        }
        public void Add(IEntity entity)
        {
            if (_edevletValidationService.CheckCustomerInfo(entity))
            {
                Console.WriteLine("Customer added: " + entity.Name);
            }
            else
            {
                Console.WriteLine("Customer cannot be added: " + entity.Name);
            }
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Customer deleted: "+entity.Name);
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Customer updated: "+entity.Name);
        }
    }
}
