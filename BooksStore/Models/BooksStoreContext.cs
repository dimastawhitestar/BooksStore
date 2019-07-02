using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksStore.Models
{
    public class BooksStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public BooksStoreContext(DbContextOptions<BooksStoreContext> options)
            : base(options)
        {
        }

    }
}
