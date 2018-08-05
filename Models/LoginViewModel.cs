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

        public LoginViewModel(List<Employee> emps, Dictionary<int, string> employeeNames)
        {
            Employees = new List<SelectListItem>(
                emps.Where(z => employeeNames.ContainsKey(z.EmployeeId)).Select(x =>
                    new SelectListItem(employeeNames[x.EmployeeId],
                    x.EmployeeId.ToString())));
        }
    }
}