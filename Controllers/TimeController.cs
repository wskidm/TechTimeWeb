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

        public TimeController(ShopMgtContext shopMgtContext, TechTimeContext techTimeContext) : base()
        {
            shopContext = shopMgtContext;
            ttContext = techTimeContext;
        }

        [HttpGet]
        public IActionResult Index()
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
        public IActionResult Index(TimeViewModel model)
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
                return Redirect("Index");
            }

            return View(
                new LoginViewModel(
                    shopContext.Employee.Where(x => !(x.Inactive || x.Deleted))
                        .OrderBy(y => y.LastName).ThenBy(z => z.FirstName)
                        .Select(x => x).ToList()));
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!string.IsNullOrEmpty(model.EmployeeId))
            {
                HttpContext.Session.SetInt32("employeeId", Convert.ToInt32(model.EmployeeId));

                return Redirect("Index");
            }

            return Redirect("Login");
        }
    }
}