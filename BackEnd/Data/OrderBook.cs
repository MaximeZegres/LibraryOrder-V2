using LibraryDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class OrderBook
    {
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int BookId { get; set; }
    }
}
