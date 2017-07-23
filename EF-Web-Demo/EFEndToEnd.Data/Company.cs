using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEndToEnd.Data
{
    public class Company
    {

        public Company()
        {
            Address = new Address();
        }

        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public Address Address { get; set; }

        public virtual ICollection<Person> Persons { get; set; } // Many to many relationship

        // Virtual is optional. Allows lazy loading but can be a problem as it will do a call later to get the related data. 
        // You may just need eager loading
    }
}
