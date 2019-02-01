namespace POS.APIs.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserMemberOf")]
    public partial class UserMemberOf
    {
        [Key]
        public int smo_id { get; set; }

        [Required]
        [StringLength(20)]
        public string grp_id { get; set; }

        [Required]
        [StringLength(20)]
        public string usr_id { get; set; }

        public virtual Group Group { get; set; }

        public virtual User User { get; set; }
    }
}
