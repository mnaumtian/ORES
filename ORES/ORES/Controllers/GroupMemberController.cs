using BusinessLogicLayer;
using BusinessObjectLayer;
using ORES.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORES.Controllers
{
    public class GroupMemberController : Controller
    {
        // GET: GroupMember
        private GroupBLL groupdb = new GroupBLL();
        private GroupMemberBLL groupMemberDb = new GroupMemberBLL();
        private UserBLL userDb = new UserBLL();
        // GET: Group
        public ActionResult Index()
        {
            return View(groupdb.GetAllGroups());
        }
        public ActionResult GroupDetails(int id)
        {
            var model = groupMemberDb.GetAllGroupMembers().Where(r=>r.GroupId.Equals(id)).ToList();
            return View(model);
        }
        public ActionResult AddGroupMember(int id)
        {
            GroupMemberViewModel model = new GroupMemberViewModel();
            model.GroupId = id;
            List<int> userIdList = new List<int>();
            foreach (var item in groupMemberDb.GetAllGroupMembers())
            {
                if (item.GroupId == id)
                {
                    userIdList.Add(item.UsersId);
                }
            }
            model.UserList = userDb.GetAllUsers().Where(r => !userIdList.Contains(r.UsersId)).ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddGroupMember(GroupMemberViewModel model, IEnumerable<int> userIdList)
        {
            if (ModelState.IsValid)
            {
                groupMemberDb.Create(model.GroupId, userIdList);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}