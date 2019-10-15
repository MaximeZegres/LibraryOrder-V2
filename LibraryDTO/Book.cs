using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryDTO
{
    public class Book
    {
        public int BookId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        public string Editor { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }
    }
}

