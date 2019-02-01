namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class WidgetsPermission
    {
        [Key]
        public long wper_id { get; set; }

        [Required]
        [StringLength(20)]
        public string grp_id { get; set; }

        public int wid_id { get; set; }

        public virtual Group Group { get; set; }

        public virtual Widget Widget { get; set; }
    }
}
