using BackEnd.Data;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasIndex(a => a.FirstName)
                .IsUnique();

            // Many-to-many: Customer <-> Order
            modelBuilder.Entity<CustomerOrder>()
                .HasKey(co => new { co.CustomerId, co.OrderId });

            // Many to many : Order <-> Book
            modelBuilder.Entity<OrderBook>()
                .HasKey(co => new { co.OrderId, co.BookId });


        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}