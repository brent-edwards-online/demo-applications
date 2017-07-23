using EFEndToEnd.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEndToEnd.DataAccess
{
    public class AddressMap : ComplexTypeConfiguration<Address>
    {
        public AddressMap()
        {
            Property(a => a.Street).HasMaxLength(50).HasColumnName("Street");
            Property(a => a.State).HasMaxLength(3).HasColumnName("State");
        }
    }
}
