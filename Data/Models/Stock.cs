namespace POS.APIs.Data.Models
{

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Stock")]
    public partial class Stock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stock()
        {
            Inventories = new HashSet<Inventory>();
            InventoryAdjustments = new HashSet<InventoryAdjustment>();
        }

        [Key]
        public int stk_id { get; set; }

        [StringLength(50)]
        public string stk_description { get; set; }

        [Column(TypeName = "text")]
        public string stk_notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryAdjustment> InventoryAdjustments { get; set; }
    }
}
