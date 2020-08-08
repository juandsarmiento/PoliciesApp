using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PoliciesWebApp.Data;
using PoliciesWebApp.Models;

namespace PoliciesWebApp.Repo
{
    public class SqlPoliciesRepo : IPoliciesRepo
    {
        private readonly PoliciesDbContext _policiesDbContext;
        public SqlPoliciesRepo(PoliciesDbContext policiesDbContext)
        {
            _policiesDbContext = policiesDbContext;
        }
        public IEnumerable<Policy> GetAllPolicies()
        {
            return _policiesDbContext.Policies
                .Include(p => p.PolicyCoverageTypes)
                .AsNoTracking()
                .ToList();
        }
        public Policy GetPolicyById(long policyId, bool tracked = false)
        {
            if (tracked)
            {
                return _policiesDbContext.Policies
                .Include(p => p.PolicyCoverageTypes)
                .FirstOrDefault(p => p.Id == policyId);
            }
            return _policiesDbContext.Policies
                .Include(p => p.PolicyCoverageTypes)
                .AsNoTracking()
                .FirstOrDefault(p => p.Id == policyId);
        }
        public Policy CreatePolicy(Policy policy)
        {
            var newPolicy = _policiesDbContext.Policies.Add(policy);
            _policiesDbContext.SaveChanges();
            return newPolicy.Entity;
        }
        public void UpdatePolicy(Policy policy)
        {
            _policiesDbContext.Policies.Update(policy);
            _policiesDbContext.SaveChanges();
        }
        public void DeletePolicy(Policy policy)
        {
            _policiesDbContext.Policies.Remove(policy);
            _policiesDbContext.SaveChanges();
        }
        public Client GetClientById(long clientId)
        {
            return _policiesDbContext.Clients
                .AsNoTracking()
                .FirstOrDefault(c => c.Id == clientId);
        }
        public void AssignPolicies(IEnumerable<PolicyClient> policyClients)
        {
            _policiesDbContext.PolicyClient.AddRange(policyClients);
            _policiesDbContext.SaveChanges();
        }
        public void CancelPolicies(IEnumerable<PolicyClient> policyClients)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<RiskType> GetAllRisks()
        {
            return _policiesDbContext.Risk
                .AsNoTracking()
                .ToList();
        }
        public IEnumerable<CoverageType> GetAllCoverages()
        {
            return _policiesDbContext.CoverageType
                .AsNoTracking()
                .ToList();
        }
        public IEnumerable<Client> GetAllClients()
        {
            return _policiesDbContext.Clients
                .Include(c => c.PolicyClients)
                .AsNoTracking()
                .ToList();
        }
        public void SaveChanges()
        {
            _policiesDbContext.SaveChanges();
        }

        
    }
}
