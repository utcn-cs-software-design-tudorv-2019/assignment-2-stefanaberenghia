using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tema2ps.Models.DBModel.Repositories
{
    public class UserRepository
    {
        public user getUser(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            user u = new user();
            foreach (user uDB in entities.users)
                if (uDB.id == id)
                    u = uDB;
            return u;
        }

        public void addUser(user u)
        {
            tema2psEntities entities = new tema2psEntities();
            entities.users.Add(u);
            entities.SaveChanges();
        }

        public void updateUser(user u)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach(user uDB in entities.users)
                if (uDB.id == u.id)
                {
                    uDB.username = u.username;
                    uDB.password = u.password;
                    uDB.type = u.type;
                }
            entities.SaveChanges();
        }

        public void deleteUserByID(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach (user uDB in entities.users)
                if (uDB.id == id)
                    entities.users.Remove(uDB);
            entities.SaveChanges();
        }

        public List<user> GetUsers()
        {
            tema2psEntities entities = new tema2psEntities();
            return entities.users.ToList();
        }
    }
}