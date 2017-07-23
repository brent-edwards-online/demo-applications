namespace EFEndToEnd.DataAccess
{
    using Data;
    using System.Data.Entity;

    public class Context : DbContext
    {
        public Context() : base("Name=ContactsDatabase")
        {

        }

        public DbSet<Person> Persons { get; set; }
        
        public DbSet<Company> Companies { get; set; }

        public DbSet<PersonType> PersonTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonTypeMap());
            modelBuilder.Configurations.Add(new AddressMap());
        }
    }
}
