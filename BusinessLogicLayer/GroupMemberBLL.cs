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
    public class GroupMemberBLL
    {
        private GroupMemberDAL groupMemberDb;
        private HttpContext context;
        public GroupMemberBLL()
        {
            groupMemberDb = new GroupMemberDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<GroupMember> GetAllGroupMembers()
        {
            return groupMemberDb.GetAllGroupMembers().Where(r => r.IsDelete == "0");
        }
        public GroupMember GetById(int Id)
        {
            return groupMemberDb.GetById(Id);
        }
        public void Create(int groupId, IEnumerable<int> userIdList)
        {
            foreach(var item in userIdList)
            {
                GroupMember groupMember = new GroupMember();
                groupMember.GroupId = groupId;
                groupMember.UsersId = item;
                groupMember.CreatedOn = System.DateTime.Now;
                groupMember.CreatedBy = context.Session["USERNAME"].ToString();
                groupMember.IsDelete = "0";
                groupMemberDb.Create(groupMember);
            }
        }
        public void Update(GroupMember groupMember)
        {
            groupMember.ModifiedOn = System.DateTime.Now;
            groupMember.ModifiedBy = context.Session["USERNAME"].ToString();
            groupMember.IsDelete = "0";
            groupMemberDb.Update(groupMember);
        }
        public void Delete(GroupMember groupMember)
        {
            groupMember.IsDelete = "1";
            groupMemberDb.Delete(groupMember);
        }
    }
}
