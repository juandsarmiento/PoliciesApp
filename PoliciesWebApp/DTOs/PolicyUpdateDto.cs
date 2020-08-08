using PoliciesWebApp.Models;
using PoliciesWebApp.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoliciesWebApp.DTOs
{
    public class PolicyUpdateDto : PolicyCreateDto, IPolicy
    {
        [Required]
        public long Id { get; set; }
    }
}
