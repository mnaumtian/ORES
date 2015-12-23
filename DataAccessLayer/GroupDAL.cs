using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GroupDAL
    {
        private ORESEntities db;
        public GroupDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<Group> GetAllGroups()
        {
            return db.Groups.ToList();
        }
        public Group GetById(int Id)
        {
            return db.Groups.Find(Id);
        }
        public void Create(Group group)
        {
            db.Groups.Add(group);
            Save();
        }
        public void Update(Group group)
        {
            db.Entry(group).State = EntityState.Modified;
            Save();
        }
        public void Delete(Group group)
        {
            db.Entry(group).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
