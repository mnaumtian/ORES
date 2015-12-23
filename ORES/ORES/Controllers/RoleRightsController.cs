using BusinessLogicLayer;
using ORES.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORES.Controllers
{
    public class RoleRightsController : Controller
    {
        // GET: RoleRights
        RoleBLL roledb = new RoleBLL();
        FormBLL formDb = new FormBLL();
        public ActionResult Index()
        {
            RoleRightViewModel model = new RoleRightViewModel();
            ConfigureModel(model);
            model.FormList = FormRightMatrix.GetFormRights();
            return View(model);
        }
        private void ConfigureModel(RoleRightViewModel model)
        {
            model.RoleList = new SelectList(roledb.GetAllRoles(), "RoleId", " Role1");
        }

        [HttpPost]
        public ActionResult Index(RoleRightViewModel roleRightsModel)
        {
            RoleRightsBLL rolerights = new RoleRightsBLL();
            RoleBLL role = new RoleBLL();
            FormBLL _form = new FormBLL();
            BusinessObjectLayer.RolesRightsManagement roleRightObject = new BusinessObjectLayer.RolesRightsManagement();
            int roleID = roleRightsModel.SelectedRole;
            IEnumerable<FormRightMatrix> forms = roleRightsModel.FormList.Where(x => x.IsAdd || x.IsView || x.IsUpdate || x.IsDeleteRight);

            foreach(FormRightMatrix form in forms)
            {
                roleRightObject.RoleRightsId = 0;
                roleRightObject.RoleId = roleID;
                roleRightObject.ModifiedBy = null;
                roleRightObject.ModifiedOn = null;
                roleRightObject.IsView = form.IsView;
                roleRightObject.IsUpdate = form.IsUpdate;
                roleRightObject.IsDelete = "0";
                roleRightObject.IsAdd = form.IsAdd;
                roleRightObject.FormId = form.FormId;
                roleRightObject.Form = _form.GetById(form.FormId);
                roleRightObject.Role = role.GetById(roleID);

                if (rolerights.IsRoleRightsExist(form.FormId, roleID))
                {
                    rolerights.Update(roleRightObject);
                }
                else
                {
                    rolerights.Create(roleRightObject);
                }
            }

            return RedirectToAction("");
        }
    }
}