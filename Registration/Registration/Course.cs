namespace Registration
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    // DONT MUCK WITH AUTO GEN CODE - it's partial, go add more stuff elsewhere
    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Sections = new HashSet<Section>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        public string Department { get; set; }

        [Required]
        [StringLength(5)]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public int Credits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Section> Sections { get; set; }
    }
}
