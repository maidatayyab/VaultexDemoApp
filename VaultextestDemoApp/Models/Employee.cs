using System;
using System.Collections.Generic;

namespace VaultextestDemoApp.Models
{
    public partial class Employee
    {
        public string? OrganisationNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
    public class EmployeeDTO : Employee
    {
        public string? OrganisationName { get; set; }
    }
}
