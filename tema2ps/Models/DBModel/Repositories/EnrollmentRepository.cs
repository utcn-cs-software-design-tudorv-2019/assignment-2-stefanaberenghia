using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tema2ps.Models.DBModel.Repositories
{
    public class EnrollmentRepository
    {
        public enrollment getenrollmentbyID(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            enrollment u = new enrollment();
            foreach (enrollment uDB in entities.enrollments)
                if (uDB.id == id)
                    u = uDB;
            return u;
        }

        public void addenrollment(enrollment u)
        {
            tema2psEntities entities = new tema2psEntities();
            entities.enrollments.Add(u);
            entities.SaveChanges();
        }

        public void updateenrollment(enrollment u)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach (enrollment uDB in entities.enrollments)
                if (uDB.id == u.id)
                {
                    uDB.userID = u.userID;
                    uDB.courseID = u.courseID;
                    uDB.grade = u.grade;
                }
            entities.SaveChanges();
        }

        public void deleteenrollmentID(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach (enrollment uDB in entities.enrollments)
                if (uDB.id == id)
                    entities.enrollments.Remove(uDB);
            entities.SaveChanges();
        }

        public List<enrollment> GetEnrollments()
        {
            tema2psEntities entities = new tema2psEntities();
            return entities.enrollments.ToList();
        }

        public int getMaxID()
        {
            tema2psEntities entities = new tema2psEntities();
            int id = 0;
            foreach (enrollment u in entities.enrollments)
                if (u.id > id)
                    id = u.id;
            return id;
        }
    }
}