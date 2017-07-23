using EFEndToEnd.Data;
using System.Data.Entity.ModelConfiguration;

namespace EFEndToEnd.DataAccess
{
    class PersonTypeMap : EntityTypeConfiguration<PersonType>
    {
        public PersonTypeMap()
        {
            HasKey(p => p.PersonTypeId);
            Property(p => p.PersonTypeId).IsRequired();
            Property(p => p.Name).IsRequired().HasMaxLength(30);
        }
    }
}
