using Microsoft.AspNetCore.Mvc;
using VaultextestDemoApp.Models;

namespace VaultextestDemoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrganisationController : ControllerBase
    {
       
        private readonly ILogger<OrganisationController> _logger;

        public OrganisationController(ILogger<OrganisationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOrganisation")]
        public JsonResult Get()
        {
            using(var context = new VaultexTestContext())
            {
                return new JsonResult(context.Organisations.ToList());
            }
        }
    }
}