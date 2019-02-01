namespace POS.APIs.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class StateTax
    {
        [Key]
        [StringLength(2)]
        public string StateTaxId { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxAmount { get; set; }
    }
}
