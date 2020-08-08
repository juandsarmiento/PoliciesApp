using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliciesWebApp.Models
{
    public class PolicyCoverageType
    {
        public long Id { get; set; }
        public long PolicyId { get; set; }
        public Policy Policy { get; set; }
        public ECoverageTypes CoverageTypeId { get; set; }
        public CoverageType CoverageType { get; set; }
    }
}
