namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class job_result
    {
        [Key]
        public int job_result_id { get; set; }

        public int applicant_id { get; set; }

        public int job_id { get; set; }

        public decimal obtained_marks_in_test { get; set; }

        public decimal obtained_marks_in_interview { get; set; }

        public int total_marks_out_of_200 { get; set; }

        public virtual job job { get; set; }
    }
}
