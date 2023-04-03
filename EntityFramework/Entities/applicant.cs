namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("applicant")]
    public partial class applicant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public applicant()
        {
            job_application = new HashSet<job_application>();
            recommended_candidates_for_job = new HashSet<recommended_candidates_for_job>();
        }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Key]
        public int applicant_id { get; set; }

        [Required]
        [StringLength(50)]
        public string address { get; set; }

        [Required]
        [StringLength(50)]
        public string email_address { get; set; }

        public int? marks_in_matriculation { get; set; }

        public int? marks_in_intermediate { get; set; }

        public int? marks_in_batchelor { get; set; }

        [Required]
        [StringLength(1)]
        public string applicant_gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_birth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<job_application> job_application { get; set; }

        public virtual black_listed_candidates black_listed_candidates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recommended_candidates_for_job> recommended_candidates_for_job { get; set; }
    }
}
