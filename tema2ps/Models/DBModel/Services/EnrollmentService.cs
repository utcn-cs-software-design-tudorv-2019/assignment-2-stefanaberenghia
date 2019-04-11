using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tema2ps.Models.DBModel.Repositories;

namespace tema2ps.Models.DBModel.Services
{
    public class EnrollmentService
    {
        public enrollment getEnrollmentByID(int id)
        {
            return new EnrollmentRepository().getenrollmentbyID(id);
        }

        public void addEnrollment(enrollment u)
        {
            new EnrollmentRepository().addenrollment(u);
        }

        public void updateEnrollment(enrollment u)
        {
            new EnrollmentRepository().updateenrollment(u);
        }

        public void deleteEnrollment(int id)
        {
            new EnrollmentRepository().deleteenrollmentID(id);
        }

        public List<enrollment> GenEnrollments()
        {
            return new EnrollmentRepository().GetEnrollments();
        }
        
        public int getMaxID()
        {
            return new EnrollmentRepository().getMaxID();
        }
    }
}