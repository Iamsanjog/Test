using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProtoType.Models;

namespace ProtoType.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService empService = new EmployeeService();

        // GET: /Employee/
        public ActionResult Index()
        {
           empService
            return View(allTrainings);
        }

        public ActionResult Create()
        {
            //EmployeeModel empModel = new EmployeeModel();

            return View();
        }
	}
}