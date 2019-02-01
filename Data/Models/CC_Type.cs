namespace POS.APIs.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

   public partial class CC_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CC_Type()
        {
            Client_CCs = new HashSet<Client_CC>();
        }

        [Key]
        public short cct_id { get; set; }

        [Required]
        [StringLength(50)]
        public string cct_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client_CC> Client_CCs { get; set; }
    }
}
