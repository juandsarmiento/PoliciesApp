using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoliciesWebApp.DTOs
{
    public class CancelPoliciesClientDto
    {
        [Required]
        [MinLength(1)]
        public IEnumerable<long> PoliciesId { get; set; }
    }
}
