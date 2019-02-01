namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Unit
    {
        [Key]
        public int unit_id { get; set; }

        [StringLength(50)]
        public string unit_description { get; set; }

        [StringLength(50)]
        public string unit_volume { get; set; }

        public int? unit_child_id { get; set; }

        public int? unit_child_quantity { get; set; }
    }
}
