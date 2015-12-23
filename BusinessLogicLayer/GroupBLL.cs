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
    public class GroupBLL
    {
        private GroupDAL groupdb;
        private HttpContext context;
        public GroupBLL()
        {
            groupdb = new GroupDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<Group> GetAllGroups()
        {
            return groupdb.GetAllGroups().Where(r => r.IsDelete == "0");
        }
        public Group GetById(int Id)
        {
            return groupdb.GetById(Id);
        }
        public void Create(Group group)
        {
            group.CreatedOn = System.DateTime.Now;
            group.CreatedBy = context.Session["USERNAME"].ToString();
            group.IsDelete = "0";
            groupdb.Create(group);
        }
        public void Update(Group group)
        {
            group.ModifiedOn = System.DateTime.Now;
            group.ModifiedBy = context.Session["USERNAME"].ToString();
            group.IsDelete = "0";
            groupdb.Update(group);
        }
        public void Delete(Group group)
        {
            group.IsDelete = "1";
            groupdb.Delete(group);
        }
    }
}
