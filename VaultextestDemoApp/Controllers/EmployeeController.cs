using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using VaultextestDemoApp.Models;

namespace VaultextestDemoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class EmployeeController : ControllerBase
    {
       
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEmployee")]
        public JsonResult Get()
        {
            using (var context = new VaultexTestContext())
            {
                //return context.Employees.ToList();
                List<EmployeeDTO> result = (from emp in context.Employees
                                            join org in context.Organisations
                                             on new { emp.OrganisationNumber }
                                             equals new { org.OrganisationNumber }
                                            select new EmployeeDTO()
                                            {
                                                FirstName = emp.FirstName,
                                                LastName = emp.LastName,
                                                OrganisationNumber = emp.OrganisationNumber,
                                                OrganisationName = org.OrganisationName
                                            }).ToList();

                return new JsonResult(result);
            }
        }
    }
}