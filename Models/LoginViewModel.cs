using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TechTime.Models.ShopMgt;

namespace TechTime.Models
{
    public class LoginViewModel
    {
        public string EmployeeId { get; set; }
        public List<SelectListItem> Employees { get; set; }

        public LoginViewModel() { }

        public LoginViewModel(List<Employee> emps)
        {
            Employees = new List<SelectListItem>(
                emps.Select(x =>
                    new SelectListItem($"{x.FirstName} {x.LastName}",
                    x.EmployeeId.ToString())));
        }
    }
}