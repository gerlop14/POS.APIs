namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Client_CCs = new HashSet<Client_CC>();
            Client_Phones = new HashSet<Client_Phone>();
            //Invoices = new HashSet<Invoice>();
            //PaymentRegisters = new HashSet<PaymentRegister>();
            //PRBatchesDetails = new HashSet<PRBatchesDetail>();
        }

        [Key]
        public int cli_id { get; set; }

        [StringLength(50)]
        public string cli_firstname { get; set; }

        [StringLength(50)]
        public string cli_lastname { get; set; }

        public bool cli_member { get; set; }

        public int? cli_membershipid { get; set; }

        [StringLength(100)]
        public string cli_address { get; set; }

        [StringLength(50)]
        public string cli_city { get; set; }

        [StringLength(2)]
        public string cli_state { get; set; }

        [StringLength(10)]
        public string cli_zip { get; set; }

        [StringLength(100)]
        public string cli_email { get; set; }

        [StringLength(100)]
        public string cli_website { get; set; }

        [Column(TypeName = "text")]
        public string cli_notes { get; set; }

        public int? cli_rating { get; set; }

        [Column(TypeName = "money")]
        public decimal cli_discount { get; set; }

        public int clit_id { get; set; }

        public DateTime? cli_birthdate { get; set; }

        public int cli_delivery { get; set; }

        public virtual Client_Type Client_Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client_CC> Client_CCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client_Phone> Client_Phones { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Invoice> Invoices { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PaymentRegister> PaymentRegisters { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRBatchesDetail> PRBatchesDetails { get; set; }
    }
}
