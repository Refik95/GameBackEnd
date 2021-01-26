using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    class GameManager : ICustomerDal
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(" New Game added: " + entity.Name);
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Game deleted: " + entity.Name);
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Game updated: " + entity.Name);
        }
    }
}
