namespace POS.APIs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class SystemObject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemObject()
        {
            GroupPermissions = new HashSet<GroupPermission>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int obj_id { get; set; }

        [StringLength(25)]
        public string obj_name { get; set; }

        public int obj_index { get; set; }

        public int obj_parent { get; set; }

        [StringLength(50)]
        public string obj_url { get; set; }

        [StringLength(50)]
        public string obj_image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupPermission> GroupPermissions { get; set; }
    }
}
