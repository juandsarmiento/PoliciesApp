using AutoMapper;
using PoliciesWebApp.DTOs;
using PoliciesWebApp.Models;
using System.Linq;

namespace PoliciesWebApp.Profiles
{
    public class PolicyProfile : Profile
    {
        public PolicyProfile()
        {
            CreateMap<PolicyCreateDto, Policy>().ForMember(
                dto => dto.PolicyCoverageTypes,
                conf => conf.MapFrom(d =>
                d.PolicyCoverageTypes.Select(f => new PolicyCoverageType
                {
                    CoverageTypeId = f
                })));
            CreateMap<PolicyUpdateDto, Policy>().ForMember(
                dto => dto.PolicyCoverageTypes,
                conf => conf.MapFrom(d =>
                d.PolicyCoverageTypes.Select(f => new PolicyCoverageType
                {
                    CoverageTypeId = f
                })));
            CreateMap<Policy, PolicyReadableDto>().ForMember(
                p => p.PolicyCoverageTypes,
                conf => conf.MapFrom(f =>
                    f.PolicyCoverageTypes.Select(p => p.CoverageTypeId)));


            CreateMap<PolicyCoverageType, PolicyCoverageTypeReadableDto>();

            CreateMap<Client, ClientReadableDto>().ForMember(
                c => c.PoliciesId,
                conf => conf.MapFrom(c => c.PolicyClients.Select(i => i.PolicyId)));

        }
    }
}
