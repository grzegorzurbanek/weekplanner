using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeekPlanner.Controllers
{
    public class ControllerBase : Controller
    {
        public JsonResult GetJsonResult(object data)
        {
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            result.Data = data;

            return result;
        }
    }
}