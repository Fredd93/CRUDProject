using DAL;
using Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService
    {
        private UserDAO userdb;

        public UserService() //
        {
            userdb = new UserDAO();
        }

        public User READUser(string name)
        {
            return userdb.READUser(name);
        }
        public User GetUserByUsername(string username)
        {
            return userdb.READUserByUsername(username);
        }
        public User GetUserById(ObjectId id)
        {
            return userdb.GetUserById(id);
        }

        public List<User> GetAllUsers()
        {
            return userdb.GetAllUsers();
        }

        public List<User> GetAllServiceUsers()
        {
            return userdb.GetAllServiceUsers();
        }
    }
}
