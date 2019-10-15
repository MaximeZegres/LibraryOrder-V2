using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class Customer : LibraryDTO.Customer
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
