using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    public class Logindetails
    {
        [Key]
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
