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
            registerDAO.AddToDataBase(username, password);
        }
    }
}
