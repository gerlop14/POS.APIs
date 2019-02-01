namespace POS.APIs.Data.Models
{

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Client_Phone
    {
        [Key]
        public int ph_id { get; set; }

        public int cli_id { get; set; }

        public int pht_id { get; set; }

        [StringLength(50)]
        public string ph_number { get; set; }

        [ForeignKey("cli_id")]
        public virtual Client Client { get; set; }

        public virtual Phone_Type Phone_Type { get; set; }
    }
}
