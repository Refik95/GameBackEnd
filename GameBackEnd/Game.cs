using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    class Game :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
