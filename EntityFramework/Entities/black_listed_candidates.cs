namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class black_listed_candidates
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int applicant_id { get; set; }

        public virtual applicant applicant { get; set; }
    }
}
