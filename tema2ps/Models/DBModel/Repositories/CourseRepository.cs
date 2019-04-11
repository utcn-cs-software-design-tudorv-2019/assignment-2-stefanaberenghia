using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tema2ps.Models.DBModel.Repositories
{
    public class CourseRepository
    {
        public course getcoursebyID(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            course u = new course();
            foreach (course uDB in entities.courses)
                if (uDB.id == id)
                    u = uDB;
            return u;
        }

        public void addcourse(course u)
        {
            tema2psEntities entities = new tema2psEntities();
            entities.courses.Add(u);
            entities.SaveChanges();
        }

        public void updatecourse(course u)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach (course uDB in entities.courses)
                if (uDB.id == u.id)
                {
                    uDB.name = u.name;
                    uDB.description = u.description;
                }
            entities.SaveChanges();
        }

        public void deletecourseID(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach (course uDB in entities.courses)
                if (uDB.id == id)
                    entities.courses.Remove(uDB);
            entities.SaveChanges();
        }

        public List<course> Getcourses()
        {
            tema2psEntities entities = new tema2psEntities();
            return entities.courses.ToList();
        }
    }
}