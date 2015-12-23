using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GroupMemberDAL
    {
        private ORESEntities db;
        public GroupMemberDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<GroupMember> GetAllGroupMembers()
        {
            return db.GroupMembers.ToList();
        }
        public GroupMember GetById(int Id)
        {
            return db.GroupMembers.Find(Id);
        }
        public void Create(GroupMember groupMember)
        {
            db.GroupMembers.Add(groupMember);
            Save();
        }
        public void Update(GroupMember groupMember)
        {
            db.Entry(groupMember).State = EntityState.Modified;
            Save();
        }
        public void Delete(GroupMember groupMember)
        {
            db.Entry(groupMember).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
