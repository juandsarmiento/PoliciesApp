using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliciesWebApp.Models
{
    interface IPolicy
    {
        string Name { get; set; }
        string Desc { get; set; }
        float Coverage { get; set; }
        DateTime StartDate { get; set; }
        int CoverageTime { get; set; }
        decimal Price { get; set; }
        ERiskTypes RiskId { get; set; }
    }
}
