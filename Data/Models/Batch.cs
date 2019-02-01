namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Batch
    {
        [Key]
        public int batch_id { get; set; }

        [Required]
        [StringLength(20)]
        public string usr_id { get; set; }

        [StringLength(50)]
        public string batch_notes { get; set; }

        [Required]
        [StringLength(20)]
        public string createdby { get; set; }

        public DateTime createddate { get; set; }

        public bool active { get; set; }

        [StringLength(20)]
        public string cancelledby { get; set; }

        public DateTime? cancelleddate { get; set; }
    }
}
