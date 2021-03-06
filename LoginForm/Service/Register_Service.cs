using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace Service
{
    public class Register_Service
    {
        RegisterDAO registerDAO = new RegisterDAO();
        public void Insert(string username, string password)
        {
            if (!registerDAO.checkExist(username))
            {
                registerDAO.AddToDataBase(username, password);
            }
            else
            {
                throw new Exception("User already exists");
            }
        }
    }
}
