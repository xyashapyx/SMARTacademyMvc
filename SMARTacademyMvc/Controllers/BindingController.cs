using SMARTacademyMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMARTacademyMvc.Controllers
{
    public class BindingController : Controller
    {
        public ActionResult NoBinding()
        {
            if (Request.Form.Count > 0)
            {
                string ID = Request.Form["StudentID"];
                string FirstName = Request.Form["StudentFirstName"];
                ViewBag.Message = $"Your Student retrieved successfully with an ID  {ID}!!";
            }
            return View();
        }

        public ActionResult SimpleTypesBinding()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SimpleTypesBinding(string studentid, string studentfirstname)
        {
            ViewBag.Message = $"Your Student retrieved successfully with an ID  {studentid}!!";
            return View();
        }

        public ActionResult BindingWithClassTypes()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BindingWithClassTypes(Student student)
        {
            ViewBag.Message = $"Your Student retrieved successfully with an ID  {student.StudentID}!!";
            return View();
        }
    }
}