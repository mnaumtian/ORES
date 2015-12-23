using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDAL
    {
        private ORESEntities db;
        public UserDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<User> GetAllUsers()
        {
            return db.Users.ToList();
        }
        public User GetById(int Id)
        {
            return db.Users.Find(Id);
        }
        public void Create(User user)
        {
            db.Users.Add(user);
            Save();
        }
        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            Save();
        }
        public void Delete(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
