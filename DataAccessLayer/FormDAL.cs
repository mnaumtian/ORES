using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FormDAL
    {
        private ORESEntities db;
        public FormDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<Form> GetAllForms()
        {
            return db.Forms.ToList();
        }
        public Form GetById(int Id)
        {
            return db.Forms.Find(Id);
        }
        public void Create(Form form)
        {
            db.Forms.Add(form);
            Save();
        }
        public void Update(Form form)
        {
            db.Entry(form).State = EntityState.Modified;
            Save();
        }
        public void Delete(Form form)
        {
            db.Entry(form).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
