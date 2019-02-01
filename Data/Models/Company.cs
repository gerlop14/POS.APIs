namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Company")]
    public partial class Company
    {
        [Key]
        public int company_id { get; set; }

        [Required]
        [StringLength(50)]
        public string company_name { get; set; }

        [Column(TypeName = "money")]
        public decimal sales_tax { get; set; }
    }
}
