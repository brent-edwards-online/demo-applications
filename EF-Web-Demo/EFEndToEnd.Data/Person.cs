using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEndToEnd.Data
{
    public class Person
    {
        public Person()
        {
            Address = new Address();
        }

        public int PersonId { get; set; }

        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        public Address Address { get; set; }

        public int PersonTypeId { get; set; }

        public virtual PersonType PersonType { get; set; }

        public ICollection<Company> Company { get; set; } // Many to many realtionships
    }
}
