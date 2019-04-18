using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tema2ps.Models.DBModel.Repositories;

namespace tema2ps.Models.DBModel.Services
{
    public class StudentInfoService
    {
        public studentInfo getStudentInfoByID(int id)
        {
            return new StudentInfoRepository().getStudentInfoByID(id);
        }

        public void addStudentInfo(studentInfo u)
        {
            new StudentInfoRepository().addstudentInfo(u);
        }

        public void updateStudentInfo(studentInfo u)
        {
            new StudentInfoRepository().updateclientInfo(u);
        }

        public void deleteStudentInfo(int id)
        {
            new StudentInfoRepository().deletestudentInfoByID(id);
        }

        public List<studentInfo> getStudentInfos()
        {
            return new StudentInfoRepository().GetstudentInfos();
        }

        public int getMaxID()
        {
            return new StudentInfoRepository().getMaxID();
        }
    }
}