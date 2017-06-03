namespace DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(64)]
        public string ProductDescription { get; set; }


        public decimal Cost { get; set; }
    }
}
