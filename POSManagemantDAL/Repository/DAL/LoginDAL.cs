using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POSManagemantDAL.Repository.DAL
{
    public class LoginDAL:CommonDAL
    {
       public DataTable Login(string userid,string password)
        {
            return Query($"Select * from t00000 where T_USER_ID ='{userid}' and T_PASSWORD='{password}'");
        }
    }
}