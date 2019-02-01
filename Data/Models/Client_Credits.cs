namespace POS.APIs.Data.Models
{

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  
    public partial class Client_Credits
    {
        [Key]
        [Column(Order = 0)]
        public int cr_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cli_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int inv_id { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal cr_amount { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal cr_balance { get; set; }
    }
}
