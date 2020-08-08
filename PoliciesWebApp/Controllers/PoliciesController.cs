using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PoliciesWebApp.Models;
using PoliciesWebApp.Repo;
using PoliciesWebApp.DTOs;
using AutoMapper;


namespace PoliciesWebApp.Controllers
{
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
        public ActionResult<IEnumerable<Policy>> GetAllPolicies()
        {

            return Ok(_policiesRepo.GetAllPolicies());
        }
        [HttpGet("{policyId}")]
        public ActionResult<Policy> GetPolicyById(long policyId)
        {
            var policy = _policiesRepo.GetPolicyById(policyId);
            if (policy != null)
                return Ok(policy);

            return NotFound();
        }
        [HttpPost]
        public ActionResult<Policy> CreatePolicy(PolicyCreateDto policy)
        {
            Policy newPolicy = _mapper.Map<Policy>(policy);
            return Created("", _policiesRepo.CreatePolicy(newPolicy));
        }
        [HttpPut]
        public ActionResult<Policy> UpdatePolicy(Policy policy)
        {
            var oldPolicy = _policiesRepo.GetPolicyById(policy.Id);
            if (oldPolicy == null)
            {

                return NotFound();
            }
            _policiesRepo.UpdatePolicy(policy);
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