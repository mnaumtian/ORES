using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RoleDAL
    {
        private ORESEntities db;
        public RoleDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<Role> GetAllRoles()
        {
            return db.Roles.ToList();
        }
        public Role GetById(int Id)
        {
            return db.Roles.Find(Id);
        }
        public void Create(Role role)
        {
            
            db.Roles.Add(role);
            Save();
        }
        public void Update(Role role)
        {
            db.Entry(role).State = EntityState.Modified;
            Save();
        }
        public void Delete(Role role)
        {
            db.Entry(role).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
