using PoliciesWebApp.Models;

namespace PoliciesWebApp.DTOs
{
    public class PolicyCoverageTypeReadableDto
    {
        public long Id { get; set; }
        public long PolicyId { get; set; }
        public ECoverageTypes CoverageTypeId { get; set; }
    }
}
