
using System.ComponentModel.DataAnnotations;

namespace PoliciesWebApp.Models
{
    public class PolicyClient
    {
        [Key]
        public long Id { get; set; }
        public long PolicyId { get; set; }
        public bool Canceled { get; set; } = false;
        public Policy Policy { get; set; }
        public long ClientId { get; set; }
        public Client Client { get; set; }
        
    }
}
