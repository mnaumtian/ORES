using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessObjectLayer;
using BusinessLogicLayer;
using ORES.ViewModels;

namespace ORES.Controllers
{
    public class EvaluationController : Controller
    {
        private ORESEntities db = new ORESEntities();
        private EvaluationBLL evaluationDb = new EvaluationBLL();
        private EvaluationManagementBLL evaluationManagementDb = new EvaluationManagementBLL();
        private UserBLL userDb = new UserBLL();
        private QuestionBLL questionDb = new QuestionBLL();
        private GroupBLL groupDb = new GroupBLL();

        // GET: Evaluation
        public ActionResult Index()
        {
            return View(evaluationDb.GetAllEvaluations());
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            EvaluationViewModel model = new EvaluationViewModel();
            ConfigureModel(model);
            return View(model);
        }

        // POST: Evaluation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EvaluationViewModel model)
        {
            if (ModelState.IsValid)
            {
                Evaluation evaluation = new Evaluation();
                evaluation.RevieweeId = model.SelectedReviewee;
                evaluation.GroupId = model.SelectedGroup;
                evaluation.ExpiryDate = model.Evaluation.ExpiryDate;
                evaluationDb.Create(evaluation);
                return RedirectToAction("Index");
            }
            ConfigureModel(model);
            return View(model);
        }

        public ActionResult Design(int id)
        {
            EvaluationManagementViewModel model = new EvaluationManagementViewModel();
            model.EvaluationId = id;
            model.EvaluationMangementList = evaluationManagementDb.GetAllEvaluationManagements().Where(r=>r.EvaluationId==id).ToList();
            ConfigureQuestionList(model);
            return View(model);
        }
        [HttpPost]
        public ActionResult Design(EvaluationManagementViewModel model)
        {
            if(ModelState.IsValid)
            {
                EvaluationManagement EvaluationManagement = new EvaluationManagement();
                EvaluationManagement.EvaluationId = model.EvaluationId;
                EvaluationManagement.IsCompulsory = model.EvaluationMangement.IsCompulsory;
                EvaluationManagement.QuestionId = model.SelectedQuestion;
                evaluationManagementDb.Create(EvaluationManagement);
                return RedirectToAction("Design",model.EvaluationId);
            }
            model.EvaluationMangementList = evaluationManagementDb.GetAllEvaluationManagements().Where(r => r.EvaluationId == model.EvaluationId).ToList();
            ConfigureQuestionList(model);
            return View(model);
        }

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            EvaluationViewModel model = new EvaluationViewModel();
            model.Evaluation = evaluationDb.GetById(id);
            if (model.Evaluation == null)
            {
                return HttpNotFound();
            }
            ConfigureModel(model);
            return View(model);
        }

        // POST: Evaluation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EvaluationViewModel model)
        {
            if (ModelState.IsValid)
            {
                Evaluation Evaluation = new Evaluation();
                Evaluation.EvaluationId = model.Evaluation.EvaluationId;
                Evaluation.ExpiryDate = model.Evaluation.ExpiryDate;
                Evaluation.CreatedBy = model.Evaluation.CreatedBy;
                Evaluation.CreatedOn = model.Evaluation.CreatedOn;
                Evaluation.GroupId = model.SelectedGroup;
                Evaluation.RevieweeId = model.SelectedReviewee;
                evaluationDb.Update(Evaluation);
                return RedirectToAction("Index");
            }
            ConfigureModel(model);
            return View(model);
        }

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            Evaluation evaluation = evaluationDb.GetById(id);
            if (evaluation == null)
            {
                return HttpNotFound();
            }
            return View(evaluation);
        }

        // POST: Evaluation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evaluation evaluation = evaluationDb.GetById(id);
            List<EvaluationManagement> list = new List<EvaluationManagement>();
            list = evaluationManagementDb.GetAllEvaluationManagements().Where(r => r.EvaluationId == id).ToList();
            foreach(var item in list)
            {
                evaluationManagementDb.Delete(item);
            }
            evaluationDb.Delete(evaluation);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEvaluationManagement(int id)
        {
            EvaluationManagement EvaluationManagement = new EvaluationManagement();
            EvaluationManagement = evaluationManagementDb.GetById(id);
            if (EvaluationManagement == null)
            {
                return HttpNotFound();
            }
            return View(EvaluationManagement);
        }
        [HttpPost, ActionName("DeleteEvaluationManagement")]
        public ActionResult DeleteEvaluationManagementConfirmed(EvaluationManagement EvaluationManagement)
        {
            EvaluationManagement em = evaluationManagementDb.GetById(EvaluationManagement.EvaluationManagementId);
            evaluationManagementDb.Delete(em);
            return RedirectToAction("Design", new { id = EvaluationManagement.EvaluationId });
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        private void ConfigureModel(EvaluationViewModel model)
        {
            model.RevieweeList = new SelectList(userDb.GetAllUsers(), "UsersId", " UsersName");
            model.GroupList = new SelectList(groupDb.GetAllGroups(), "GroupId", "GroupName");
        }
        private void ConfigureQuestionList(EvaluationManagementViewModel model)
        {
            model.QuestionList = new SelectList(questionDb.GetAllQuestions(), "QuestionId", "Question1");
        }
    }
}
