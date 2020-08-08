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
    }
}