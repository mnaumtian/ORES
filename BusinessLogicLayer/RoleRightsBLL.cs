using BusinessObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLogicLayer
{
    public class RoleRightsBLL
    {
        private RoleRightsManagementDAL roleRightsManagementDb;
        private HttpContext context;
        public RoleRightsBLL()
        {
            roleRightsManagementDb = new RoleRightsManagementDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<RolesRightsManagement> GetAllRolesRightsManagement()
        {
            return roleRightsManagementDb.GetAllRoleRIghtsManagements().Where(r => r.IsDelete == "0");
        }
        public RolesRightsManagement GetById(int Id)
        {
            return roleRightsManagementDb.GetById(Id);
        }

        public bool IsRoleRightsExist(int FormId,int RoleId)
        {
            IEnumerable<RolesRightsManagement> rolerights = GetAllRolesRightsManagement().Where(p => p.FormId == FormId && p.RoleId == RoleId );
            return rolerights.Count() > 0;
        }

        public void Create(RolesRightsManagement rolesRightsManagement)
        {
            rolesRightsManagement.CreatedOn = System.DateTime.Now;
            rolesRightsManagement.CreatedBy = context.Session["USERNAME"].ToString();
            rolesRightsManagement.IsDelete = "0";
            roleRightsManagementDb.Create(rolesRightsManagement);

        }
        public void Update(RolesRightsManagement rolesRightsManagement)
        {
            rolesRightsManagement.ModifiedOn = System.DateTime.Now;
            rolesRightsManagement.ModifiedBy = context.Session["USERNAME"].ToString();
            rolesRightsManagement.IsDelete = "0";
            roleRightsManagementDb.Update(rolesRightsManagement);
        }
        public void Delete(RolesRightsManagement rolesRightsManagement)
        {
            rolesRightsManagement.IsDelete = "1";
            roleRightsManagementDb.Delete(rolesRightsManagement);
        }
    }
}
