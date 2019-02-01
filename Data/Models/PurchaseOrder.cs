namespace POS.APIs.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PurchaseOrder
    {
        [Key]
        public int po_id { get; set; }

        public DateTime po_date { get; set; }

        public int cli_id { get; set; }

        [Column(TypeName = "money")]
        public decimal? po_discount { get; set; }
    }
}
