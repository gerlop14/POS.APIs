namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class PRBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRBatch()
        {
            PaymentRegisters = new HashSet<PaymentRegister>();
            PRBatchesDetails = new HashSet<PRBatchesDetail>();
        }

        [Key]
        public long prbch_id { get; set; }

        [StringLength(100)]
        public string prbch_description { get; set; }

        public DateTime prbch_paymentdate { get; set; }

        public int prbch_paymenttype { get; set; }

        public DateTime prbch_createddate { get; set; }

        [Required]
        [StringLength(50)]
        public string prbch_createdby { get; set; }

        [StringLength(100)]
        public string prbch_otherinfo { get; set; }

        [Column(TypeName = "money")]
        public decimal prbch_amount { get; set; }

        public bool prbch_nochargecredit { get; set; }

        public virtual Payment_Types Payment_Types { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentRegister> PaymentRegisters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRBatchesDetail> PRBatchesDetails { get; set; }
    }
}
