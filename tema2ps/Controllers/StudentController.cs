using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tema2ps.Models.DBModel.Repositories;
using tema2ps.Models.DBModel.Services;

namespace tema2ps.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ViewEnrollments()
        {
            List<enrollment> list = new List<enrollment>();
            list = new EnrollmentService().GenEnrollments();
            List<enrollment> returnEnroll = new List<enrollment>();
            foreach (enrollment e in list)
                if (e.userID == int.Parse(Session["loggedUser"].ToString()))
                    returnEnroll.Add(e);
            return View(returnEnroll);
        }

        public ActionResult Create()
        {
            List<course> list = new List<course>();
            list = new CourseService().GetCourses();
            ViewData["courseID"] = list;

            return View("CreateEnrollment");
        }

        public ActionResult CreateEnrollment(enrollment e)
        {

            e.id = new EnrollmentService().getMaxID() + 1;
            e.userID = int.Parse(Session["loggedUser"].ToString());
            e.grade = 0;
            new EnrollmentService().addEnrollment(e);
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
            enrollment e= new EnrollmentService().getEnrollmentByID(id);
            return View("DetailsEnrollment" , e);
        }

        public ActionResult Delete(int id)
        {
             new EnrollmentService().deleteEnrollment(id);
            return RedirectToAction("ViewEnrollments");
        }
    }
}