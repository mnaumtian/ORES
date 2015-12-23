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
    public class UserBLL
    {
        private UserDAL userdb;
        private HttpContext context;
        public UserBLL()
        {
            userdb = new UserDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return userdb.GetAllUsers().Where(r => r.IsDelete == "0");
        }
        public User GetById(int Id)
        {
            return userdb.GetById(Id);
        }
        public void Create(User user)
        {
            user.CreatedOn = System.DateTime.Now;
            //user.CreatedBy = context.Session["USERNAME"].ToString();
            user.IsDelete = "0";
            userdb.Create(user);
        }
        public void Update(User user)
        {
            user.ModifiedOn = System.DateTime.Now;
            user.ModifiedBy = context.Session["USERNAME"].ToString();
            user.IsDelete = "0";
            userdb.Update(user);
        }
        public void Delete(User user)
        {
            user.IsDelete = "1";
            userdb.Delete(user);
        }
        public bool CheckExistance(User user)
        {
            int count = userdb.GetAllUsers().Where(x => x.UsersName.Equals(user.UsersName)).Count();
            if (count!=0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
