
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoliciesWebApp.Models
{
    public class Client
    { 
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<PolicyClient> PolicyClients { get; set; }
    }
}
