namespace DataAccess.Entities
{
    using System.Data.Entity;

    public class StoreDbContext : DbContext
    {
        public StoreDbContext() : base("name=StoreConnectionString")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                    .HasRequired<Customer>(s => s.Customer)
                    .WithMany(s => s.Orders)
                    .HasForeignKey(k => k.CustomerId);


            modelBuilder.Entity<OrderItem>()
                    .HasRequired<Order>(o => o.Order)
                    .WithMany(s => s.OrderItems)
                    .HasForeignKey(k => k.OrderId);
            
        }
    }
}
