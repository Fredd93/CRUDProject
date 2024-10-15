using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class LoginService
    {
        private UserService userService;

        public LoginService()
        {
            userService = new UserService();
        }
        public bool LoginAuthentication(string username, string password)
        {
            User user = userService.GetUserByUsername(username);

            if (user !=null && user.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}
