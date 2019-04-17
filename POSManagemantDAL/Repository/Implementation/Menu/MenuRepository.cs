using POSManagemantDAL.Models;
using POSManagemantDAL.Repository.Interface.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace POSManagemantDAL.Repository.Implementation.Menu
{
    public class MenuRepository :IMenu
    {
        private POS_Management_DBEntities1 obj = new POS_Management_DBEntities1();
        public MenuRepository(POS_Management_DBEntities1 _obj)
        {
            obj = _obj;
        }
        public IEnumerable GetMenulist()
        {
            //var query;
            IEnumerable query = Enumerable.Empty<object>();
            try
            {
                query = (from i in obj.T00001
                         select new
                         {
                             T_FORM_TYPE = i.T_FORM_TYPE,
                             T_FORM_NAME = i.T_FORM_NAME,
                             T_NAME = i.T_NAME
                         }).ToList();
                //query = (from i in obj.T74015
                //         join j in obj.T74004
                //         on i.T_EMP_ID equals j.T_EMP_ID
                //         join k in obj.T74005 on j.T_EMP_TYP_ID equals k.T_EMP_TYP_ID
                //         where i.T_AMBU_REG_ID == T_AMBU_REG_ID
                //         select new
                //         {
                //             T_AMBU_REG_ID = i.T_AMBU_REG_ID,
                //             T_EMP_ASSIGN_ID = i.T_EMP_ASSIGN_ID,
                //             T_EMP_TYP_ID = k.T_EMP_TYP_ID,
                //             T_EMP_TYP_NAME = k.T_LANG2_NAME,
                //             T_EMP_ID = j.T_EMP_ID,
                //             EMP_NAME1 = j.T_FIRST_LANG2_NAME,
                //             EMP_NAME2 = j.T_FATHER_LANG2_NAME,
                //             EMP_NAME3 = j.T_GFATHER_LANG2_NAME,
                //             EMP_NAME4 = j.T_FAMILY_LANG2_NAME,
                //         }).AsEnumerable().Select((r, i) => new
                //         {
                //             T_AMBU_REG_ID = r.T_AMBU_REG_ID,
                //             T_EMP_ASSIGN_ID = r.T_EMP_ASSIGN_ID,
                //             T_EMP_TYP_ID = r.T_EMP_TYP_ID,
                //             T_EMP_TYP_NAME = r.T_EMP_TYP_NAME,
                //             T_EMP_ID = r.T_EMP_ID,
                //             FullName = r.EMP_NAME1 + " " + r.EMP_NAME2 + " " + r.EMP_NAME3 + " " + r.EMP_NAME4
                //         }).ToList();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
            }
            return query;
        }
        public void Dispose()
        {
            obj.Dispose();
        }

        //public DataTable GetMenulist()
        //{
       
        //    return Query($"select * from T00001");
        //}
    }
}