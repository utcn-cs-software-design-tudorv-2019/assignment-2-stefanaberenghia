using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tema2ps.Models.DBModel.Repositories;

namespace tema2ps.Models.DBModel.Services
{
    public class CourseService
    {
        public course getCourseByID(int id)
        {
            return new CourseRepository().getcoursebyID(id);
        }

        public void addCourse(course u)
        {
            new CourseRepository().addcourse(u);
        }

        public void updateCourse(course u)
        {
            new CourseRepository().updatecourse(u);
        }

        public void deleteCourse(int id)
        {
            new CourseRepository().deletecourseID(id);
        }

        public List<course> GetCourses()
        {
            return new CourseRepository().Getcourses();
        }
    }
}