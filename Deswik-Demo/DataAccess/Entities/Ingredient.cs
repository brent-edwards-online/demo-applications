namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ingredient")]
    public partial class Ingredient
    {
        public int ingredientid { get; set; }

        public int recipeid { get; set; }

        [Required]
        [StringLength(64)]
        public string name { get; set; }

        public int quantity { get; set; }

        [Required]
        [StringLength(20)]
        public string unit { get; set; }

        public int? sortrder { get; set; }

        public virtual Recipe Recipe { get; set; }

        public virtual Unit Unit1 { get; set; }
    }
}
