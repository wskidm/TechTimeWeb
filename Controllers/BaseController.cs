using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechTime.Controllers
{
    public class BaseController : Controller
    {
        private int _employeeId = 0;
        protected int employeeId
        {
            get
            {
                if (_employeeId == 0 && IsLoggedIn)
                {
                    _employeeId = HttpContext.Session.GetInt32("employeeId").Value;
                }
                return _employeeId;
            }
        }

        protected bool IsLoggedIn
        {
            get
            {
                return HttpContext.Session.GetInt32("employeeId").HasValue;
            }
        }
    }
}