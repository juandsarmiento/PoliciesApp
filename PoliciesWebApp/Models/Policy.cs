using PoliciesWebApp.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoliciesWebApp.Models
{
    public class Policy
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Desc { get; set; }
        [Required]
        [ValidateCoverage]
        public float Coverage { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public int CoverageTime { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public ERiskTypes RiskId { get; set; }

        public ICollection<PolicyCoverageType> PolicyCoverageTypes { get; set; }
        public ICollection<PolicyClient> PolicyClients { get; set; }
    }
}
