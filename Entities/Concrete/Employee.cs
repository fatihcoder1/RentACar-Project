using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Employee: IEntities
    {
        public int EmployeeID { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
    }
}
