using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    interface ICustomerDal
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
