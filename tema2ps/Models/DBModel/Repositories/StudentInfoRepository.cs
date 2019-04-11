using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tema2ps.Models.DBModel.Repositories
{
    public class StudentInfoRepository
    {
        public studentInfo getStudentInfoByID(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            studentInfo u = new studentInfo();
            foreach (studentInfo uDB in entities.studentInfoes)
                if (uDB.id == id)
                    u = uDB;
            return u;
        }

        public void addstudentInfo(studentInfo u)
        {
            tema2psEntities entities = new tema2psEntities();
            entities.studentInfoes.Add(u);
            entities.SaveChanges();
        }

        public void updateclientInfo(studentInfo u)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach (studentInfo uDB in entities.studentInfoes)
                if (uDB.id == u.id)
                {
                    uDB.userID = u.userID;
                    uDB.identificationNR = u.identificationNR;
                    uDB.groupNR = u.groupNR;
                }
            entities.SaveChanges();
        }

        public void deletestudentInfoByID(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach (studentInfo uDB in entities.studentInfoes)
                if (uDB.id == id)
                    entities.studentInfoes.Remove(uDB);
            entities.SaveChanges();
        }

        public List<studentInfo> GetstudentInfos()
        {
            tema2psEntities entities = new tema2psEntities();
            return entities.studentInfoes.ToList();
        }
    }
}