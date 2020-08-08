using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliciesWebApp.Models
{
    public class CoverageType
    {
        public ECoverageTypes Id { get; set; }
        public string Name { get; set; }
        public ICollection<PolicyCoverageType> PolicyCoverageTypes { get; set; }
    }
}
