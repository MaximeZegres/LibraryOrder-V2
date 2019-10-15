using BackEnd.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class Book : LibraryDTO.Book
    {
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}
