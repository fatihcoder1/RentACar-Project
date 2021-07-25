using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class RentalOrders : IEntity
    {
        [Key]
        public int RentalOrderID { get; set; }
        public int CarID { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        
        public DateTime RentStartDate { get; set; }
    }
}
