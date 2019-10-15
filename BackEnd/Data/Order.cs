using BackEnd.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class Order : LibraryDTO.Book
    {
        public int OrderId { get; set; }

        public virtual ICollection<OrderBook> OrderBooks { get; set; }

        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }


    }
}
