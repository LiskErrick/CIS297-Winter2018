namespace Registration
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RegistrationDatabase : DbContext
    {
        public RegistrationDatabase()
            : base("name=Registration")
        {
            // When adding the .mdf file to the project, go to properties of the mdf file 
            // and set Copy to output directory to Copy if Newer
            // if you want a fresh copy of the model, change to Copy Always
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(e => e.Sections)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Sections)
                .WithRequired(e => e.Faculty)
                .HasForeignKey(e => e.Faculty_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Enrollments)
                .WithRequired(e => e.Section)
                .HasForeignKey(e => e.Section_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Enrollments)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.Student_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
