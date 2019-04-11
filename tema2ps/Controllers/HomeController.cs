using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tema2ps.Models.DBModel;
using tema2ps.Models.DBModel.Repositories;
using tema2ps.Models.DBModel.Services;

namespace tema2ps.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login(user u)
        {
            int id;
            UserService service = new UserService();

            id = service.login(u.username, u.password);
           
            if (id >= 0)
            {
                Session["loggedUser"] = id;
                user logged = service.getUserByID(id);
                if (logged.type == 0)
                    return RedirectToAction("ViewEnrollments", "Student");
                    
                else
                    return RedirectToAction("Index", "Teacher");
            }
            ViewBag.Message = "Wrong credentials";
            return View("Index");
        }
    }
}