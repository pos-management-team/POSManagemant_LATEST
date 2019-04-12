using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagemantDAL.Repository.Interface.Menu
{
    public interface IMenu : IDisposable
    {
        IEnumerable GetMenulist();
    }
}
