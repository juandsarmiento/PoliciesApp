using PoliciesWebApp.Models;
using PoliciesWebApp.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoliciesWebAppTests.Controllers
{
    class MockSql : IPoliciesRepo
    {
        public void AssignPolicies(IEnumerable<PolicyClient> policyClients)
        {
            return;
        }

        public void AssignPoliciesOfClient(long clientId, IEnumerable<long> policiesId)
        {
            return;
        }

        public void CancelPolicies(IEnumerable<PolicyClient> policyClients)
        {
            return;
        }

        public void CancelPoliciesOfClient(long clientId, IEnumerable<long> policiesId)
        {
            return;
        }

        public Policy CreatePolicy(Policy policy)
        {
            return policy;
        }

        public void DeletePolicy(Policy policyId)
        {
            return;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return new List<Client>();
        }

        public IEnumerable<CoverageType> GetAllCoverages()
        {
            return new List<CoverageType>();
        }

        public IEnumerable<Policy> GetAllPolicies()
        {
            return new List<Policy>();
        }

        public IEnumerable<RiskType> GetAllRisks()
        {
            return new List<RiskType>();
        }

        public Client GetClientById(long clientId)
        {
            return new Client
            {
                Id = clientId
            };
        }

        public Policy GetPolicyById(long policyId, bool tracked = false)
        {
            return new Policy
            {
                Id = policyId,
            };
        }

        public void SaveChanges()
        {
            return;
        }

        public void UpdatePolicy(Policy policy)
        {
            return;
        }
    }
}
