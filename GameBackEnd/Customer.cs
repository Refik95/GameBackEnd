using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd
{
    class Customer : IEntity
    {
        public int NationalityNumber { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int YearOfBirth { get; set; }
    }
}
