using EFEndToEnd.Data;
using System.Data.Entity.ModelConfiguration;

namespace EFEndToEnd.DataAccess
{
    public class PersonMap: EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            HasKey(p => p.PersonId);
            Property(p => p.PersonId).IsRequired();
            Property(p => p.FirstName).IsRequired().HasMaxLength(30);
            HasRequired(p => p.PersonType).WithMany(p => p.Persons).HasForeignKey(p => p.PersonTypeId);
        }
    }
}
