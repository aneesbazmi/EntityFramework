using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityFramework
{
    public partial class JMSEntities : DbContext
    {
        public JMSEntities()
            : base("name=JMSEntities")
        {
        }

        public virtual DbSet<applicant> applicants { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<job_application> job_application { get; set; }
        public virtual DbSet<job_result> job_result { get; set; }
        public virtual DbSet<black_listed_candidates> black_listed_candidates { get; set; }
        public virtual DbSet<recommended_candidates_for_job> recommended_candidates_for_job { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<applicant>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.email_address)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.applicant_gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .HasMany(e => e.job_application)
                .WithRequired(e => e.applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<applicant>()
                .HasOptional(e => e.black_listed_candidates)
                .WithRequired(e => e.applicant);

            modelBuilder.Entity<applicant>()
                .HasMany(e => e.recommended_candidates_for_job)
                .WithRequired(e => e.applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<department>()
                .Property(e => e.dept_name)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .HasMany(e => e.jobs)
                .WithRequired(e => e.department)
                .HasForeignKey(e => e.job_dept_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job>()
                .Property(e => e.job_title)
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .Property(e => e.job_posting_city_name)
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .HasMany(e => e.job_application)
                .WithRequired(e => e.job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job>()
                .HasMany(e => e.job_result)
                .WithRequired(e => e.job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job_application>()
                .Property(e => e.payment_method)
                .IsUnicode(false);

            modelBuilder.Entity<job_result>()
                .Property(e => e.obtained_marks_in_test)
                .HasPrecision(5, 2);

            modelBuilder.Entity<job_result>()
                .Property(e => e.obtained_marks_in_interview)
                .HasPrecision(5, 2);
        }
    }
}
