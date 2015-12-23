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
    public class FormController : Controller
    {
        private FormBLL formdb = new FormBLL();

        // GET: Form
        public ActionResult Index()
        {
            return View(formdb.GetAllForms());
        }

        // GET: Form/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Form/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Form form)
        {
            if (ModelState.IsValid)
            {
                formdb.Create(form);
                return RedirectToAction("Index");
            }

            return View(form);
        }

        // GET: Form/Edit/5
        public ActionResult Edit(int id)
        {
            Form form = formdb.GetById(id);
            if (form == null)
            {
                return HttpNotFound();
            }
            return View(form);
        }

        // POST: Form/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Form form)
        {
            if (ModelState.IsValid)
            {
                formdb.Update(form);
                return RedirectToAction("Index");
            }
            return View(form);
        }

        // GET: Form/Delete/5
        public ActionResult Delete(int id)
        {
            Form form = formdb.GetById(id);
            if (form == null)
            {
                return HttpNotFound();
            }
            return View(form);
        }

        // POST: Form/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Form form = formdb.GetById(id);
            formdb.Delete(form);
            return RedirectToAction("Index");
        }
    }
}
