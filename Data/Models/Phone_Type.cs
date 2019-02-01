namespace POS.APIs.Data.Models
{ 
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Phone_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phone_Type()
        {
            Client_Phones = new HashSet<Client_Phone>();
        }

        [Key]
        public int pht_id { get; set; }

        [StringLength(50)]
        public string pht_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client_Phone> Client_Phones { get; set; }
    }
}
