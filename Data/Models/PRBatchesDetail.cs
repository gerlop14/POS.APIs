namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("PRBatchesDetail")]
    public partial class PRBatchesDetail
    {
        [Key]
        public long prbchdet_id { get; set; }

        public long prbch_id { get; set; }

        public int cli_id { get; set; }

        public bool cc_charged { get; set; }

        [StringLength(100)]
        public string cc_charge_msg { get; set; }

        public bool cc_charge_void { get; set; }

        [StringLength(50)]
        public string cc_charge_refid { get; set; }

        public bool credited { get; set; }

        public bool emailed { get; set; }

        public virtual Client Client { get; set; }

        public virtual PRBatch PRBatch { get; set; }
    }
}
