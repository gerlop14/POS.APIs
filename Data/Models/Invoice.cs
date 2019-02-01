namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            InvoicePayments = new HashSet<InvoicePayment>();
            InvoicesDetails = new HashSet<InvoicesDetail>();
            InvoicesDiscounts = new HashSet<InvoicesDiscount>();
        }

        [Key]
        public int inv_id { get; set; }

        public DateTime inv_date { get; set; }

        public int cli_id { get; set; }

        [StringLength(50)]
        public string inv_description { get; set; }

        public int inv_status { get; set; }

        [Column(TypeName = "money")]
        public decimal inv_tax { get; set; }

        [Column(TypeName = "money")]
        public decimal inv_discount { get; set; }

        [Column(TypeName = "money")]
        public decimal inv_taxpercent { get; set; }

        [StringLength(200)]
        public string inv_notes { get; set; }

        [Column(TypeName = "money")]
        public decimal inv_total { get; set; }

        [Column(TypeName = "money")]
        public decimal? inv_subtotal { get; set; }

        [StringLength(20)]
        public string inv_createdby { get; set; }

        [StringLength(20)]
        public string inv_closedby { get; set; }

        [StringLength(20)]
        public string inv_cancelledby { get; set; }

        [StringLength(20)]
        public string inv_reopenedby { get; set; }

        public DateTime? inv_cancelleddate { get; set; }

        public DateTime? inv_reopeneddate { get; set; }

        [Column(TypeName = "money")]
        public decimal inv_shipping { get; set; }

        public int del_id { get; set; }

        public bool inv_delivered { get; set; }

        public int stk_id { get; set; }

        public DateTime? inv_deliverydate { get; set; }

        public bool inv_showasatab { get; set; }

        public int? batch_id { get; set; }

        public bool inv_ws { get; set; }

        public int term_id { get; set; }

        [StringLength(20)]
        public string inv_deliveredby { get; set; }

        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoicePayment> InvoicePayments { get; set; }

        public virtual InvoiceStatu InvoiceStatu { get; set; }

        public virtual InvoiceTerm InvoiceTerm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoicesDetail> InvoicesDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoicesDiscount> InvoicesDiscounts { get; set; }
    }
}
