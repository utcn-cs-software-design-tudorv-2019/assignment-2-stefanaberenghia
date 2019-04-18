using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tema2ps.Models.DBModel.Repositories;

namespace tema2ps.Models.DBModel.Services
{
    public class UserService
    {

        public int login(string username, string password)
        {
            List<user> users = new UserRepository().GetUsers();

            foreach(user u in users)
            {
                if (u.username.Equals(username) && u.password.Equals(password))
                    return u.id;
            }

            return -1;
        }

        public user getUserByID(int id)
        {
            return new UserRepository().getUser(id);
        }

        public void registerUser(user u)
        {
            new UserRepository().addUser(u);
        }

        public void updateProfile(user u)
        {
            new UserRepository().updateUser(u);
        }

        public void deleteAccount(int id)
        {
            new UserRepository().deleteUserByID(id);
        }

        public List<user> getAllUsers()
        {
            return new UserRepository().GetUsers();
        }
    }
}