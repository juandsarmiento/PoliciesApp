using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PoliciesWebApp.Models;
using PoliciesWebApp.Repo;
using PoliciesWebApp.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace PoliciesWebApp.Controllers { 

    [ApiController]
    [Route("api/[controller]")]
    public class PoliciesController : ControllerBase
    {
        private readonly IPoliciesRepo _policiesRepo;
        private readonly IMapper _mapper;
        public PoliciesController(IPoliciesRepo policiesRepo, IMapper mapper)
        {
            _policiesRepo = policiesRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PolicyReadableDto>> GetAllPolicies()
        {
            var policies = _policiesRepo.GetAllPolicies();
            var mappedPolicies = _mapper.Map<IEnumerable<PolicyReadableDto>>(policies);
            return Ok(mappedPolicies);
        }
        [HttpGet("{policyId}")]
        public ActionResult<PolicyReadableDto> GetPolicyById(long policyId)
        {
            var policy = _policiesRepo.GetPolicyById(policyId);
            if (policy != null)
            {
                var mappedPolicy = _mapper.Map<PolicyReadableDto>(policy);
                
                return Ok(mappedPolicy);
            }
                
            return NotFound();
        }
        [HttpPost]
        public ActionResult<PolicyReadableDto> CreatePolicy(PolicyCreateDto policy)
        {
            Policy newPolicy = _mapper.Map<Policy>(policy);
            var policyCreated = _policiesRepo.CreatePolicy(newPolicy);
            return Created("", _mapper.Map<PolicyReadableDto>(policyCreated));
        }
        [HttpPut]
        public ActionResult UpdatePolicy(PolicyUpdateDto policy)
        {
            var oldPolicy = _policiesRepo.GetPolicyById(policy.Id);
            if (oldPolicy == null)
            {

                return NotFound();
            }
            Policy newPolicy = _mapper.Map<Policy>(policy);
            _policiesRepo.UpdatePolicy(newPolicy);
            return NoContent();
        }
        [HttpDelete("{policyId}")]
        public ActionResult DeletePolicy(long policyId)
        {
            var policy2del = _policiesRepo.GetPolicyById(policyId);
            if (policy2del == null)
                return NotFound();
            _policiesRepo.DeletePolicy(policy2del);

            return NoContent();
        }
    }
}