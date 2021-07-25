using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public short CarYear { get; set; }
       
        
        public int CustomerID { get; set; }
    }
}
