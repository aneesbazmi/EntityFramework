namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("job")]
    public partial class job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public job()
        {
            job_application = new HashSet<job_application>();
            job_result = new HashSet<job_result>();
        }

        [Required]
        [StringLength(50)]
        public string job_title { get; set; }

        [Key]
        public int job_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime job_adverstisement_date { get; set; }

        public int job_dept_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime job_last_date_apply { get; set; }

        public byte job_scale { get; set; }

        public byte job_total_seats { get; set; }

        public byte total_women_seats { get; set; }

        public byte total_open_merit_seats { get; set; }

        [Column(TypeName = "date")]
        public DateTime? job_result_declaration_date { get; set; }

        [Required]
        [StringLength(50)]
        public string job_posting_city_name { get; set; }

        public byte is_contract_based { get; set; }

        public virtual department department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<job_application> job_application { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<job_result> job_result { get; set; }
    }
}
