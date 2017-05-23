using SMARTacademyMvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMARTacademyMvc.Controllers
{
    [LogActionFilter]
    public class ActionFilterController : Controller
    {
        [OutputCache(Duration = 10)]
        public string Time()
        {
            return DateTime.Now.ToString("T");
        }
    }
}