namespace Registration
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Enrollment")]
    public partial class Enrollment
    {
        public int Id { get; set; }

        public int Section_Id { get; set; }

        public int Student_Id { get; set; }

        [Required]
        [StringLength(2)]
        public string Grade { get; set; }

        public virtual Section Section { get; set; }

        public virtual Student Student { get; set; }
    }
}
