namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class InventoryAdjustment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryAdjustment()
        {
            InventoryAdjustmentDetails = new HashSet<InventoryAdjustmentDetail>();
        }

        [Key]
        public int invadj_id { get; set; }

        public DateTime invadj_date { get; set; }

        public short invadj_type { get; set; }

        public int stk_id { get; set; }

        public int? stk_id_from { get; set; }

        [StringLength(100)]
        public string invadj_notes { get; set; }

        public short invadj_status { get; set; }

        [StringLength(50)]
        public string createdby { get; set; }

        public DateTime createddate { get; set; }

        public virtual InvAdjStatu InvAdjStatu { get; set; }

        public virtual InvAdjType InvAdjType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryAdjustmentDetail> InventoryAdjustmentDetails { get; set; }

        public virtual Stock Stock { get; set; }
    }
}
