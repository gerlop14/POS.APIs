namespace POS.APIs.Data.Models
{
    using System.ComponentModel.DataAnnotations;

      public partial class Client_CC
    {
        [Key]
        public long clicc_id { get; set; }

        public int cli_id { get; set; }

        public int? cli_ccmonth { get; set; }

        public int? cli_ccyear { get; set; }

        [StringLength(5)]
        public string cli_ccsec { get; set; }

        [StringLength(100)]
        public string cli_firstname { get; set; }

        [StringLength(100)]
        public string cli_lastname { get; set; }

        [StringLength(100)]
        public string cli_name { get; set; }

        [StringLength(50)]
        public string cli_address { get; set; }

        [StringLength(50)]
        public string cli_address2 { get; set; }

        [StringLength(50)]
        public string cli_city { get; set; }

        [StringLength(2)]
        public string cli_st { get; set; }

        [StringLength(10)]
        public string cli_zipcode { get; set; }

        [MaxLength(128)]
        public byte[] cli_ccno { get; set; }

        public short? cct_id { get; set; }

        public virtual CC_Type CC_Type { get; set; }

        public virtual Client Client { get; set; }
    }
}
