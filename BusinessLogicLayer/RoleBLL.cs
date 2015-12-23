using BusinessObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace BusinessLogicLayer
{
    public class RoleBLL
    {
        private RoleDAL roledb;
        private HttpContext context;
        public RoleBLL()
        {
            roledb = new RoleDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<Role> GetAllRoles()
        {
            return roledb.GetAllRoles().Where(r => r.IsDelete == "0");
        }
        public Role GetById(int Id)
        {
            return roledb.GetById(Id);
        }
        public void Create(Role role)
        {
            role.CreatedOn = System.DateTime.Now;
            role.CreatedBy = context.Session["USERNAME"].ToString();
            role.IsDelete = "0";
            roledb.Create(role);
            
        }
        public void Update(Role role)
        {
            role.ModifiedOn = System.DateTime.Now; 
            role.ModifiedBy = context.Session["USERNAME"].ToString();
            role.IsDelete = "0";
            roledb.Update(role);
        }
        public void Delete(Role role)
        {
            role.IsDelete = "1";
            roledb.Delete(role);
        }
    }
}
