using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEndToEnd.Data
{
    public class PersonType
    {
        public int PersonTypeId { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        public virtual ICollection<Person> Persons { get; set; } // virtual allows lazy loading of Persons
    }
}
