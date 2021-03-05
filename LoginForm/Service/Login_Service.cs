using System;
using DAL;
using Model;

namespace Service
{
    public class Login_Service
    {
        LoginDAO loginDAO = new LoginDAO();

        public bool GetUser(string name, string password)
        {
            try
            {
                User user = loginDAO.GetUser(name); // get user in dal layer
                return CheckPassWord(user, name, password); // compare and check
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private bool CheckPassWord(User user, string name, string password)
        {
            if ((user is null) || (user.name != name) || (user.password != password))
            {
                return false;
            }
            else
                return true;
        }
    }
}
