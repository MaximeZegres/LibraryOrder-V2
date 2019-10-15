using LibraryDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class CustomerOrder
    {
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

    }
}
