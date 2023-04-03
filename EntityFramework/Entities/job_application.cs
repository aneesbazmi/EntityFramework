namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class job_application
    {
        public int job_id { get; set; }

        [Key]
        public int application_id { get; set; }

        public int applicant_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime job_application_date { get; set; }

        [Required]
        [StringLength(20)]
        public string payment_method { get; set; }

        public int? payment_amount { get; set; }

        public virtual applicant applicant { get; set; }

        public virtual job job { get; set; }
    }
}
