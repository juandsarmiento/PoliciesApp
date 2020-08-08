using PoliciesWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliciesWebApp.Data
{
    public class Seeding
    {
        private readonly RiskType[] Risks = new RiskType[]
        {
            new RiskType
            {
                Id = ERiskTypes.Low,
                Name = ERiskTypes.Low.ToString()
            },
            new RiskType
            {
                Id = ERiskTypes.Medium,
                Name = ERiskTypes.Medium.ToString()
            },
            new RiskType
            {
                Id = ERiskTypes.MediumHigh,
                Name = ERiskTypes.MediumHigh.ToString()
            },
            new RiskType
            {
                Id = ERiskTypes.High,
                Name = ERiskTypes.High.ToString()
            }
        };
        private readonly CoverageType[] CoveragesTypes = new CoverageType[]
        {
            new CoverageType
            {
                Id = ECoverageTypes.EarthQuake,
                Name = ECoverageTypes.EarthQuake.ToString()
            },
            new CoverageType
            {
                Id = ECoverageTypes.Fire,
                Name = ECoverageTypes.Fire.ToString()
            },
            new CoverageType
            {
                Id = ECoverageTypes.Lost,
                Name = ECoverageTypes.Lost.ToString()
            },
            new CoverageType
            {
                Id = ECoverageTypes.Thefth,
                Name = ECoverageTypes.Thefth.ToString()
            },
            new CoverageType
            {
                Id = ECoverageTypes.Others,
                Name = ECoverageTypes.Others.ToString()
            }
        };
        private readonly Client[] Clients = new Client[]
        {
            new Client
            {
                Id = 1,
                Name = "Company 1"
            },
            new Client
            {
                Id = 2,
                Name = "Company 2"
            }
        };
        private IEnumerable<Policy> getRandomPolicies(int nRegs)
        {
            int i = 0;
            Random random = new Random();
            while (i < nRegs)
            {
                var riskTypeIndex = random.Next(0, Risks.Length);
                int id = i + 1;
                yield return new Policy
                {
                    Id = id,
                    Name = $"PolicyTest #{i}",
                    Desc = $"DescriptionTest #{i}",
                    Coverage = random.Next(0, 100),
                    StartDate = DateTime.Now,
                    CoverageTime = (short)random.Next(1, 12),
                    Price = (decimal)random.NextDouble(),
                    RiskId = Risks[riskTypeIndex].Id//,
                };
                i++;
            }
        }
        private IEnumerable<PolicyCoverageType> getRandomPolicyCoverageTypes(Policy[] policies, CoverageType[] coverageTypes)
        {
            Random random = new Random();
            long id = 1;
            foreach (var policy in policies)
            {
                var coverageTypeIndex = random.Next(0, CoveragesTypes.Length);
                yield return new PolicyCoverageType
                {
                    Id = id++,
                    PolicyId = policy.Id,
                    CoverageTypeId = coverageTypes[coverageTypeIndex].Id,
                };
            }

        }
        private IEnumerable<PolicyClient> getRandomPolicyClients(int nRegs, Policy[] policies, Client[] clients)
        {
            Random random = new Random();
            long i = 0;
            while (i < nRegs)
            {
                var clientIndex = random.Next(0, clients.Length);
                var policiestIndex = random.Next(0, policies.Length);
                yield return new PolicyClient
                {
                    Id = i + 1,
                    PolicyId = policies[policiestIndex].Id,
                    ClientId = clients[clientIndex].Id,
                };
                i++;
            }
        }
        public void GetRandomData(out RiskType[] risks, out CoverageType[] coverageType,
            out Client[] clients, out Policy[] policies, out PolicyCoverageType[] policyCoverageTypes, out PolicyClient[] policyClient)
        {
            risks = Risks;
            coverageType = CoveragesTypes;
            clients = Clients;
            policies = getRandomPolicies(100).ToArray();
            policyCoverageTypes = getRandomPolicyCoverageTypes(policies, coverageType).ToArray();
            policyClient = getRandomPolicyClients(20, policies, clients).ToArray();


        }
    }
}
