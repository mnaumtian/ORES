using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessObjectLayer;
using BusinessLogicLayer;
using ORES.ViewModels;

namespace ORES.Controllers
{
    public class UserController : Controller
    {
        private RoleBLL roledb = new RoleBLL();
        private UserBLL userdb = new UserBLL();
        
        // GET: User
        public ActionResult Index()
        {
            var users = userdb.GetAllUsers();
            //var users = db.Users.Include(u => u.Role);
            return View(users);
        }
        public ActionResult UserProfile()
        {
            User user = userdb.GetAllUsers().Single(r=>r.UsersName.Equals(User.Identity.Name));
            return View(user);
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = userdb.GetAllUsers().Single(r => r.UsersName.Equals(User.Identity.Name));
                if(user.Password.Equals(model.CurrentPassword))
                {
                    user.Password = model.Password;
                    userdb.Update(user);
                    TempData["Success"] = "Password Changed Successfully";
                    //return RedirectToAction("UserProfile");
                }
                else
                {
                    ModelState.AddModelError("CurrentPassword","Incorrect Current Password...");
                }
            }
            return View(model);
        }

        [Authorize(Roles="Admin")]
        // GET: User/Create
        public ActionResult Create()
        {
            UserViewModel model = new UserViewModel();
            ConfigureModel(model);
            return View(model);
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.UsersName = model.user.UsersName;
                user.FirstName = model.user.FirstName;
                user.LastName = model.user.LastName;
                user.Password = model.user.Password;
                user.Email = model.user.Email;
                user.Phone = model.user.Phone;
                user.Address = model.user.Address;
                user.IsDelete = "0";
                if (model.SelectedRole.HasValue)
                {
                    user.RoleId = (int)model.SelectedRole;
                }
                if(!userdb.CheckExistance(user))
                {
                    userdb.Create(user);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("user.UsersName", "Username already exists...");
                }
            }

            ConfigureModel(model);
            return View(model);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            UserViewModel user = new UserViewModel();
            user.user = userdb.GetById(id);
                //db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ConfigureModel(user);
            return View(user);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel model)
        {
            User user = new User();
            user.UsersId = model.user.UsersId;
            user.UsersName = model.user.UsersName;
            user.FirstName = model.user.FirstName;
            user.LastName = model.user.LastName;
            user.Password = model.user.Password;
            user.CreatedBy = model.user.CreatedBy;
            user.CreatedOn = model.user.CreatedOn;
            user.Email = model.user.Email;
            user.Phone = model.user.Phone;
            user.Address = model.user.Address;
            if (model.SelectedRole.HasValue)
            {
                user.RoleId = (int)model.SelectedRole;
            }
            user.IsDelete = "0";
            if (ModelState.IsValid)
            {
                userdb.Update(user);
                return RedirectToAction("Index");
            }
            ConfigureModel(model);
            return View(model);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            User user = userdb.GetById(id);
                //db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            User user = userdb.GetById(id);
            userdb.Delete(user);
            return RedirectToAction("Index");
        }

        private void ConfigureModel(UserViewModel model)
        {
            model.RolesList = new SelectList(roledb.GetAllRoles(), "RoleId", " Role1");
        }
    }
}
