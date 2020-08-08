using PoliciesWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoliciesWebApp.DTOs
{
    public class ClientReadableDto
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<long> PoliciesId { get; set; }
    }
}
