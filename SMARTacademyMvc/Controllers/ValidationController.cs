using SMARTacademyMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMARTacademyMvc.Controllers
{
    public class ValidationController : Controller
    {
        private MovieRepository _movieRepository;

        public ValidationController()
        {
            _movieRepository = new MovieRepository();
        }

        // GET: Validation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Movie movie)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }

        [AcceptVerbs("Get", "Post")]
        public ActionResult VerifyTitle(string title)
        {
            if (!_movieRepository.VerifyTitle(title))
            {
                return Json(data: $"Email {title} is already in use.");
            }

            return Json(data: true);
        }
    }
}