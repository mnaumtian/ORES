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

namespace ORES.Controllers
{
    public class AnswerTypeController : Controller
    {
        private AnswerTypeBLL answerTypeBll= new AnswerTypeBLL();

        // GET: AnswerType
        public ActionResult Index()
        {
            return View(answerTypeBll.GetAllAnswerTypes());
        }

        // GET: AnswerType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnswerType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AnswerType answerType)
        {
            if (ModelState.IsValid)
            {
                answerTypeBll.Create(answerType);
                return RedirectToAction("Index");
            }

            return View(answerType);
        }

        // GET: AnswerType/Edit/5
        public ActionResult Edit(int id)
        {
            AnswerType answerType = answerTypeBll.GetById(id);
            if (answerType == null)
            {
                return HttpNotFound();
            }
            return View(answerType);
        }

        // POST: AnswerType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AnswerType answerType)
        {
            if (ModelState.IsValid)
            {
                answerTypeBll.Update(answerType);
                return RedirectToAction("Index");
            }
            return View(answerType);
        }

        // GET: AnswerType/Delete/5
        public ActionResult Delete(int id)
        {
            AnswerType answerType = answerTypeBll.GetById(id);
            if (answerType == null)
            {
                return HttpNotFound();
            }
            return View(answerType);
        }

        // POST: AnswerType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnswerType answerType = answerTypeBll.GetById(id);
            answerTypeBll.Delete(answerType);
            return RedirectToAction("Index");
        }
    }
}
