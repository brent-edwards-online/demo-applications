using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class OrderItem
    {
        [Key, Required]
        public int OrderItemId { get; set; }

        [Required, Range(0, Int32.MaxValue)]
        public int Quantity { get; set; }

        [Required, Range(0, Int32.MaxValue)]
        public decimal Cost { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public virtual Order Order { get; set; }


        [Required]
        public int ProductId { get; set; }

        [Required]
        public Product Product { get; set; }
     }
}
