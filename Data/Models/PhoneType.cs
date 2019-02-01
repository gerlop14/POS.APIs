namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class PhoneType
    {
        [Key]
        public int pho_id { get; set; }

        [Required]
        [StringLength(50)]
        public string pho_description { get; set; }
    }
}
