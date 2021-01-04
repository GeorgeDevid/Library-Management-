using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    public class BookDetail
    {
        [Key]
        public int BookId { get; set; }
        
        public string BookTitle { get; set; }

        public int ISBN { get; set; }

        public string Auther { get; set; }

        public string Category { get; set; }
        
        public string Publisher { get; set; }

    }
}
