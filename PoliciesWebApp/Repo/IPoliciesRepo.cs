using PoliciesWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliciesWebApp.Repo
{
    public interface IPoliciesRepo
    {
        void SaveChanges();
        IEnumerable<Policy> GetAllPolicies();
        Policy GetPolicyById(long policyId,bool tracked = false);
        Policy CreatePolicy(Policy policy);
        void UpdatePolicy(Policy policy);
        void DeletePolicy(Policy policyId);
        Client GetClientById(long clientId);
        void AssignPolicies(IEnumerable<PolicyClient> policyClients);
        IEnumerable<RiskType> GetAllRisks();
        void CancelPolicies(IEnumerable<PolicyClient> policyClients);
        IEnumerable<CoverageType> GetAllCoverages();
        IEnumerable<Client> GetAllClients();
    }
}
