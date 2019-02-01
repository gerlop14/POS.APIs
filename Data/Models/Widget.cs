namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Widget
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Widget()
        {
            WidgetsPermissions = new HashSet<WidgetsPermission>();
        }

        [Key]
        public int wid_id { get; set; }

        [StringLength(50)]
        public string wid_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WidgetsPermission> WidgetsPermissions { get; set; }
    }
}
