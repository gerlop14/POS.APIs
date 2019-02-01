namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class UserPermission
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string obj_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string usr_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool per_visible { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool per_enabled { get; set; }

        public virtual User User { get; set; }
    }
}
