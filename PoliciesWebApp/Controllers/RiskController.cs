using Microsoft.AspNetCore.Mvc;
using PoliciesWebApp.Repo;

namespace PoliciesWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RiskController : ControllerBase
    {
        private readonly IPoliciesRepo _policiesRepo;
        public RiskController(IPoliciesRepo policiesRepo)
        {
            _policiesRepo = policiesRepo;
        }
        [HttpGet]
        public ActionResult GetAllRisks()
        {
            return Ok(_policiesRepo.GetAllRisks());
        }
    }
}