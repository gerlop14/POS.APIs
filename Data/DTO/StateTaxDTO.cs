using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POS.APIs.Models.DTO
{
    public class StateTaxDTO
    {
        [Key]
        [StringLength(2)]
        public string Id { get; set; }
        public decimal Amount { get; set; }
    }
}
