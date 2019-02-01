namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Inventory")]
    public partial class Inventory
    {
        [Key]
        public int inv_id { get; set; }

        public int prod_id { get; set; }

        public int stk_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal inv_quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual Stock Stock { get; set; }
    }
}
