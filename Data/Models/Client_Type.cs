namespace POS.APIs.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
   
    public partial class Client_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client_Type()
        {
            Clients = new HashSet<Client>();
        }

        [Key]
        public int clit_id { get; set; }

        [StringLength(50)]
        public string clit_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Clients { get; set; }
    }
}
