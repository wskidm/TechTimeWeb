using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechTime.Models;
using TechTime.Models.ShopMgt;
using TechTime.Models.TechTime;

namespace TechTime.Controllers
{
    public class TimeController : BaseController
    {
        private ShopMgtContext shopContext;
        private TechTimeContext ttContext;

        private Dictionary<int, string> employeeNames;

        public TimeController(ShopMgtContext shopMgtContext, TechTimeContext techTimeContext) : base()
        {
            shopContext = shopMgtContext;
            ttContext = techTimeContext;

            employeeNames = new Dictionary<int, string>()
            {
                {1, "Tammy" },
                {2, "Bill" },
                {4, "Thad" },
                {8, "Robert" },
                {12, "Steve" }
            };
        }

        [HttpGet]
        public IActionResult Event(string id)
        {
            if (!IsLoggedIn)
            {
                return Redirect("Login");
            }

            var model = new TimeViewModel
            {
                eventDateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
            };
            populateTimeModel(model);

            return View(model);
        }

        [HttpPost]
        public IActionResult Event(TimeViewModel model)
        {
            if (!IsLoggedIn)
            {
                return Redirect("Login");
            }

            var evt = new Event();
            evt.EventTypeId = model.eventTypeId;
            evt.EventDateTime = DateTime.Parse(model.eventDateTime);
            evt.Note = model.note;
            evt.EmployeeId = employeeId;
            evt.JobId = model.jobId;
            evt.JobRevision = 1;
            evt.LastUpdateDateTime = DateTime.Now;
            evt.LastEditedId = employeeId;

            ttContext.Events.Add(evt);
            ttContext.SaveChanges();

            model = new TimeViewModel
            {
                eventDateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                message = "Event Saved"
            };
            populateTimeModel(model);

            return View(model);
        }

        public IActionResult Menu()
        {
            if (!IsLoggedIn)
            {
                return Redirect("Login");
            }

            return View(new MenuViewModel { IsShort = false });
        }

        private void populateTimeModel(TimeViewModel model)
        {
            model.eventTypes = ttContext.EventTypes.Select(x => new SelectListItem(x.Name, x.EventTypeId.ToString())).ToList();
            model.jobTypes = shopContext.CannedJob.Select(x => new SelectListItem(x.Name, x.CannedJobId.ToString())).ToList();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (IsLoggedIn)
            {
                return Redirect("Menu");
            }

            return View(
                new LoginViewModel(
                    shopContext.Employee.Where(x => !(x.Inactive || x.Deleted))
                        .OrderBy(y => y.LastName).ThenBy(z => z.FirstName)
                        .Select(x => x).ToList(),
                employeeNames));
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!string.IsNullOrEmpty(model.EmployeeId))
            {
                HttpContext.Session.SetInt32("employeeId", Convert.ToInt32(model.EmployeeId));

                return Redirect("Menu");
            }

            return Redirect("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return Redirect("Login");
        }
    }
}