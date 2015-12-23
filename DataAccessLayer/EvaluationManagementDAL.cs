using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EvaluationManagementDAL
    {
        private ORESEntities db;
        public EvaluationManagementDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<EvaluationManagement> GetAllEvaluationManagements()
        {
            return db.EvaluationManagements.ToList();
        }
        public EvaluationManagement GetById(int Id)
        {
            return db.EvaluationManagements.Find(Id);
        }
        public void Create(EvaluationManagement evaluationManagement)
        {
            db.EvaluationManagements.Add(evaluationManagement);
            Save();
        }
        public void Update(EvaluationManagement evaluationManagement)
        {
            db.Entry(evaluationManagement).State = EntityState.Modified;
            Save();
        }
        public void Delete(EvaluationManagement evaluationManagement)
        {
            db.Entry(evaluationManagement).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
