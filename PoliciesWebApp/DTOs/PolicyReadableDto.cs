﻿using PoliciesWebApp.Models;
using PoliciesWebApp.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoliciesWebApp.DTOs
{
    public class PolicyReadableDto
    {
        [Required]
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
        public HashSet<ECoverageTypes> PolicyCoverageTypes { get; set; }

    }
}
