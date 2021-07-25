using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer: IEntity
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
