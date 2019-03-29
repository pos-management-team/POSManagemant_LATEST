using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using POSManagemantDAL.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POSManagemant.Controllers
{
    public class LoginController : Controller
    {
        LoginDAL _loginDal = new LoginDAL();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CheckLogin(string loginName, string password)
        {
            var CheckLoginData = _loginDal.Login(loginName, password);
            string JSONstring = string.Empty;
            JSONstring = JsonConvert.SerializeObject(CheckLoginData);
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
            return Json(JSONstring, JsonRequestBehavior.AllowGet);
        }
    }
}