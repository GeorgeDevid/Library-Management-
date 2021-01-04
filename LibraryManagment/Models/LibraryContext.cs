using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    public class LibraryContext:DbContext 

    { 
        public LibraryContext(DbContextOptions<LibraryContext>options):base(options)
        {

        }
        public DbSet<BookDetail> BookDetail { get; set; }
        public DbSet<Logindetails>Logindetails { get; set; }

    }
}
