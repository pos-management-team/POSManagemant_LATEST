using POSManagemantDAL.Repository.Implementation.Menu;
using POSManagemantDAL.Repository.Interface.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POSManagemant.Controllers.Menu
{
    public class MenuController : Controller
    {
        MenuRepository repository = new MenuRepository();
        //private readonly IMenu repository;

        //public MenuController(IMenu ObjectIRepository)
        //{

        //     repository = ObjectIRepository;
        //}


        // GET: Menu
        public ActionResult Menu()
        {
            return View();
        }



        public ActionResult  GetMenulist()
        {
           
      //  var Data = "";
            var Data = repository.GetMenulist();
           
            //string JSONstring = string.Empty;
            //JSONstring = JsonConvert.SerializeObject(CheckLoginData);

            //JArray obj = JArray.Parse(JSONstring);
            //if (CheckLoginData.Rows.Count > 0)
            //{
            //    Session["T_USER_NAME"] = obj[0]["T_USER_NAME"].ToString();
            //    Session["T_USER_NAME2"] = obj[0]["T_USER_NAME2"].ToString();
            //    Session["T_ROLE_CODE"] = obj[0]["T_ROLE_CODE"].ToString();
            //    Session["T_ENTRY_USER"] = obj[0]["T_ENTRY_USER"].ToString();
            //    Session["T_UPD_USER"] = obj[0]["T_UPD_USER"].ToString();
            //    Session["T_EMP_CODE"] = obj[0]["T_EMP_CODE"].ToString();
            //    Session["T_LOGIN_NAME"] = obj[0]["T_LOGIN_NAME"].ToString();
            //    Session["T_SITE_CODE"] = obj[0]["T_SITE_CODE"].ToString();
            //}
            return Json(Data, JsonRequestBehavior.AllowGet);
        }
    }
}