using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagemantDAL.Repository.Interface
{
    public interface ILogin
    {
        DataTable CheckLogin(string T_LOGIN_NAME, string T_PWD);
    }
}
