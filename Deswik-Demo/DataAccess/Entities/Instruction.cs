namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Instruction")]
    public partial class Instruction
    {
        public int instructionid { get; set; }

        public int recipeid { get; set; }

        [Required]
        [StringLength(200)]
        public string description { get; set; }

        public int? sortrder { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
