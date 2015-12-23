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
    public class FormBLL
    {
        private FormDAL formdb;
        private HttpContext context;
        public FormBLL()
        {
            formdb = new FormDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<Form> GetAllForms()
        {
            return formdb.GetAllForms().Where(r => r.IsDelete == "0");
        }
        public Form GetById(int Id)
        {
            return formdb.GetById(Id);
        }
        public void Create(Form form)
        {
            form.CreatedOn = System.DateTime.Now;
            form.CreatedBy = context.Session["USERNAME"].ToString();
            form.IsDelete = "0";
            formdb.Create(form);
        }
        public void Update(Form form)
        {
            form.ModifiedOn = System.DateTime.Now;
            form.ModifiedBy = context.Session["USERNAME"].ToString();
            form.IsDelete = "0";
            formdb.Update(form);
        }
        public void Delete(Form form)
        {
            form.IsDelete = "1";
            formdb.Delete(form);
        }
    }
}
