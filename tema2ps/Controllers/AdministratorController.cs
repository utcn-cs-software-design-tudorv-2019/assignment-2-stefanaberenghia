using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tema2ps.Models.DBModel.Repositories;
using tema2ps.Models.DBModel.Services;

namespace tema2ps.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator
        public ActionResult Index()
        {
            List<studentInfo> list = new List<studentInfo>();
            list = new StudentInfoService().getStudentInfos();
            return View(list);
        }

       
        public ActionResult Create()
        {
            List<user> list = new UserService().getAllUsers();
            ViewData["users"] = list;

            return View("CreateEnrollment");
        }

        public ActionResult CreateStudentInfo(studentInfo e)
        {

            e.id = new StudentInfoService().getMaxID() + 1;
           
            new StudentInfoService().addStudentInfo(e);
            return RedirectToAction("ViewEnrollments");
        }

        public ActionResult Edit()
        {
            List<course> list = new List<course>();
            list = new CourseService().GetCourses();
            ViewData["courseID"] = list;
            return View("EditEnrollment");
        }

        public ActionResult EditEnrollment(enrollment e)
        {
            new EnrollmentService().updateEnrollment(e);
            return RedirectToAction("ViewEnrollments");
        }



        public ActionResult Details(int id)
        {
            enrollment e = new EnrollmentService().getEnrollmentByID(id);
            return View("DetailsEnrollment", e);
        }

        public ActionResult Delete(int id)
        {
            new EnrollmentService().deleteEnrollment(id);
            return RedirectToAction("ViewEnrollments");
        }
    }
}
