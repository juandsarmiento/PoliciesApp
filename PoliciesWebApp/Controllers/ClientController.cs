using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PoliciesWebApp.DTOs;
using PoliciesWebApp.Repo;
using System.Collections.Generic;

namespace PoliciesWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IPoliciesRepo _policiesRepo;
        private readonly IMapper _mapper;
        public ClientController(IPoliciesRepo policiesRepo, IMapper mapper)
        {
            _policiesRepo = policiesRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ClientReadableDto>> GetAllClients()
        {
            var clients = _policiesRepo.GetAllClients();
            return Ok(_mapper.Map<IEnumerable<ClientReadableDto>>(clients));
        }
        [HttpPatch("{clientId}/cancelpolicies")]
        public ActionResult CancelPolicy(long clientId, CancelPoliciesClientDto clientPolicies)
        {
            _policiesRepo.CancelPoliciesOfClient(clientId, clientPolicies.PoliciesId);
            return NoContent();
        }
        [HttpPatch("{clientId}/assignpolicies")]
        public ActionResult AssignPolicies(long clientId, CancelPoliciesClientDto clientPolicies)
        {
            _policiesRepo.AssignPoliciesOfClient(clientId, clientPolicies.PoliciesId);
            return NoContent();
        }
    }
}