namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Discounts_Products = new HashSet<Discounts_Products>();
            Inventories = new HashSet<Inventory>();
            InvoicesDetails = new HashSet<InvoicesDetail>();
            MemberQtlySel_detail = new HashSet<MemberQtlySel_detail>();
        }

        [Key]
        public int prod_id { get; set; }

        [StringLength(50)]
        public string prod_description { get; set; }

        [StringLength(50)]
        public string prod_barcode { get; set; }

        public int prod_category1 { get; set; }

        public int prod_category2 { get; set; }

        public int? prod_unit { get; set; }

        [Column(TypeName = "money")]
        public decimal? prod_price { get; set; }

        [Column(TypeName = "money")]
        public decimal? prod_cost { get; set; }

        public bool prod_taxable { get; set; }

        public bool prod_status { get; set; }

        public bool prod_isservice { get; set; }

        public bool prod_discount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? prod_reorder { get; set; }

        [Column(TypeName = "money")]
        public decimal? prod_price_ws { get; set; }

        public virtual Category1 Category1 { get; set; }

        public virtual Category2 Category2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Discounts_Products> Discounts_Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoicesDetail> InvoicesDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberQtlySel_detail> MemberQtlySel_detail { get; set; }
    }
}
