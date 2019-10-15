using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDTO
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public bool IsContacted { get; set; }

        public Customer Customer { get; set; }
    }
}
