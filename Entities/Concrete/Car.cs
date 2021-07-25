using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntities
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public short CarYear { get; set; }
        public string Category { get; set; }
    }
}
