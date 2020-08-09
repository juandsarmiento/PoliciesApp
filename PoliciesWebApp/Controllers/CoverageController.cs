using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PoliciesWebApp.Repo;

namespace PoliciesWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoverageController : Controller
    {
        private readonly IPoliciesRepo _policiesRepo;
        public CoverageController(IPoliciesRepo policiesRepo)
        {
            _policiesRepo = policiesRepo;
        }
        [HttpGet]
        public ActionResult GetAllCoverages()
        {
            return Ok(_policiesRepo.GetAllCoverages());
        }
    }
}