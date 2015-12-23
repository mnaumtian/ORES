using BusinessLogicLayer;
using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ORES.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login user)
        {
            if(ModelState.IsValid)
            {
                if (Membership.ValidateUser(user.Username, user.Password))
                {
                    Session["USERNAME"] = user.Username;
                    Session["LOGINTIME"] = DateTime.Now;
                    //Session["USERID"] = user.UsersId;
                    //Session["NAME"] = user.FirstName + " " + user.LastName;
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return RedirectToAction("Home", "Home");
                }
                return RedirectToAction("Login");
            }
            return View(user);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["USERID"] = null;
            Session["USERNAME"] = null;
            Session["LOGINTIME"] = null;
            Session["NAME"] = null;
            return RedirectToAction("Login","Account");
        }
    }
}