using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekPlanner.Models;

namespace WeekPlanner.Controllers
{
    public class TasksController : Controller
    {
        //
        // GET: /Tasks/

        public ActionResult Index()
        {
            var model = new List<Task>();
            model.Add(new Task() { Id = 1, Title = "Zadanie 1" });
            model.Add(new Task() { Id = 2, Title = "Zadanie 2" });
            return View(model);
        }

    }
}
