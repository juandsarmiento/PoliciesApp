using System.Collections.Generic;

namespace PoliciesWebApp.Models
{
    public class RiskType
    {
        public ERiskTypes Id { get; set; }
        public string Name { get; set; }
        public ICollection<Policy> Policies { get; set; }
    }
}
