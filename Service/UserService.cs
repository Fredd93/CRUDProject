using DAL;
using Model;
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
    }
}
