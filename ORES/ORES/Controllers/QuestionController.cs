using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessObjectLayer;
using ORES.ViewModels;
using System.Collections;
using BusinessLogicLayer;

namespace ORES.Controllers
{
    public class QuestionController : Controller
    {
        private QuestionBLL questiondb = new QuestionBLL();
        private AnswerTypeBLL answerdb = new AnswerTypeBLL(); 

        // GET: Question
        public ActionResult Index()
        {
            return View(questiondb.GetAllQuestions());
        }

        // GET: Question/Create
        public ActionResult Create()
        {
            QuestionViewModel model = new QuestionViewModel();
            configureAnswerTypeList(model);
            return View(model);
        }

        // POST: Question/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                Question question = new Question();
                question.AnswerTypeId = model.SelectedAnswerType;
                question.IsKPI = model.Question.IsKPI;
                question.Question1 = model.Question.Question1;
                question.Weight = model.Question.Weight;
                questiondb.Create(question);
                return RedirectToAction("Index");
            }
            configureAnswerTypeList(model);
            return View(model);
        }

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {
            QuestionViewModel question = new QuestionViewModel();
            question.Question = questiondb.GetById(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            configureAnswerTypeList(question);
            return View(question);
        }

        // POST: Question/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(QuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                Question question = new Question();
                question.QuestionId = model.Question.QuestionId;
                question.AnswerTypeId = model.SelectedAnswerType;
                question.IsKPI = model.Question.IsKPI;
                question.Question1 = model.Question.Question1;
                question.Weight = model.Question.Weight;
                question.CreatedBy = model.Question.CreatedBy;
                question.CreatedOn = model.Question.CreatedOn;
                questiondb.Update(question);
                return RedirectToAction("Index");
            }
            configureAnswerTypeList(model);
            return View(model);
        }

        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {

            Question question = questiondb.GetById(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: Question/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Question question = questiondb.GetById(id);
            questiondb.Delete(question);
            return RedirectToAction("Index");
        }

        private void configureAnswerTypeList(QuestionViewModel model)
        {
            model.AnswerTypeList = new SelectList(answerdb.GetAllAnswerTypes(), "AnswerTypeId", "AnswerType1");
        }
    }
}
