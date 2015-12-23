using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RoleRightsManagementDAL
    {
        private ORESEntities db;
        public RoleRightsManagementDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<RolesRightsManagement> GetAllRoleRIghtsManagements()
        {
            return db.RolesRightsManagements.ToList();
        }
        public RolesRightsManagement GetById(int Id)
        {
            return db.RolesRightsManagements.Find(Id);
        }
        public void Create(RolesRightsManagement rolesRightsManagement)
        {
            db.RolesRightsManagements.Add(rolesRightsManagement);
            Save();
        }
        public void Update(RolesRightsManagement rolesRightsManagement)
        {
            db.Entry(rolesRightsManagement).State = EntityState.Modified;
            Save();
        }
        public void Delete(RolesRightsManagement rolesRightsManagement)
        {
            db.Entry(rolesRightsManagement).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
